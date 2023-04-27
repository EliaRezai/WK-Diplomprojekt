using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Physiotool.Application.Infrastructure;
using Physiotool.Application.Services.HolidayCalendar;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient(opt => new CalendarService(2000, 2100));

// JWT Authentication ******************************************************************************
byte[] secret = Convert.FromBase64String(builder.Configuration["Secret"]);
builder.Services
    .AddAuthentication(options => options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secret),
            ValidateAudience = false,
            ValidateIssuer = false
        };
    });
// *************************************************************************************************

builder.Services.AddDbContext<PhysioContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("sqlite"));
});
builder.Services.AddControllers();
if (builder.Environment.IsDevelopment())
{
    // Für den vite Dev Server. Er greift von einem anderen Port auf die API zu.
    builder.Services.AddCors(options =>
        options.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
}

// *************************************************************************************************

var app = builder.Build();
app.UseHttpsRedirection();
// Im Development Mode erstellen wir bei jedem Serverstart die Datenbank neu.
using (var scope = app.Services.CreateScope())
using (var db = scope.ServiceProvider.GetRequiredService<PhysioContext>())
{
    db.CreateDatabase(isDevelopment: app.Environment.IsDevelopment());
}
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.Run();