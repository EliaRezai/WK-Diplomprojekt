using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Physiotool.Application.Dto;
using Physiotool.Application.Infrastructure;
using Physiotool.Webapi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xunit;

namespace Physiotool.Test;

public class AppointmentControllerTests : IDisposable
{
    private readonly SqliteConnection _connection;
    private readonly PhysioContext _db;
    private readonly AppointmentController _controller;

    public AppointmentControllerTests()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        var opt = new DbContextOptionsBuilder<PhysioContext>()
            .UseSqlite(_connection)
            .Options;
        _db = new PhysioContext(opt);
        _db.Database.EnsureCreated();
        _controller = new AppointmentController(_db);
    }

    public T? GetPropertyValue<T>(object? obj, string name) =>
        obj is null ? default : (T)obj.GetType().GetProperty(name)!.GetValue(obj)!;

    [Fact]
    public void AddAppointmentSuccessTest()
    {
        var date = DateTime.Now.Date.AddDays(1);
        var newAppointment = new NewAppointmentCmd(
            Date: date, Time: new TimeSpan(8, 0, 0), PatientFirstname: "PatientFirstname",
            PatientLastname: "PatientLastname", PatientStreet: "PatientStreet", PatientZip: 1000,
            PatientCity: "PatientCity", PatientEmail: "email@mail.at", PatientPhone: "+43123");

        var result = _controller.AddAppointment(newAppointment);

        var createdResult = Assert.IsType<CreatedAtActionResult>(result);
        var guid = GetPropertyValue<Guid>(createdResult.Value, "Guid");
        Assert.True(guid != default);
        _db.ChangeTracker.Clear();
        Assert.True(_db.Patients.Count() == 1);
        Assert.True(_db.Appointments.Any(a => a.Guid == guid));
    }

    [Fact]
    public void AddAppointmentWithExistingPatientSuccessTest()
    {
        var date = DateTime.Now.Date.AddDays(1);
        var newAppointment = new NewAppointmentCmd(
            Date: date, Time: new TimeSpan(8, 0, 0), PatientFirstname: "PatientFirstname",
            PatientLastname: "PatientLastname", PatientStreet: "PatientStreet", PatientZip: 1000,
            PatientCity: "PatientCity", PatientEmail: "email@mail.at", PatientPhone: "+43123");
        var newAppointment2 = newAppointment with { Date = date.AddDays(1) };

        _controller.AddAppointment(newAppointment);
        var result = _controller.AddAppointment(newAppointment2);

        var createdResult = Assert.IsType<CreatedAtActionResult>(result);
        var guid = GetPropertyValue<Guid>(createdResult.Value, "Guid");
        Assert.True(guid != default);
        _db.ChangeTracker.Clear();
        Assert.True(_db.Patients.Count() == 1);
        Assert.True(_db.Appointments.Any(a => a.Guid == guid));
    }

    public void Dispose()
    {
        _db.Dispose();
        _connection.Dispose();
    }
}