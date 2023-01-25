using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Physiotool.Application.Infrastructure;
using Physiotool.Application.Model;
using Physiotool.Application.Services;
using System;
using System.Linq;

namespace Physiotool.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly PhysioContext _db;
        private readonly CalendarService _calendarService;

        public CalendarController(PhysioContext db, CalendarService calendarService)
        {
            _db = db;
            _calendarService = calendarService;
        }

        /// <summary>
        /// GET https://localhost:5001/api/calendar/2022/1
        /// Holt sich einen Monat aus dem CalendarService und fügt bei jedem Tag die gespeicherten
        /// Termine ein. So kann das Frontend einen Monatskalender mit allen Terminen erstellen.
        /// </summary>
        [HttpGet("{year:int}/{month:int}")]
        public IResult GetCalendar(int year, int month)
        {
            var calendarDays = _calendarService.GetDaysOfMonth(year, month);
            var appointments = _db.Appointments.Include(a => a.Patient).Where(a => a.Date.Month == month && a.Date.Year == year).ToList();
            var result = calendarDays.GroupJoin(
                appointments, c => c.DateTime, a => a.Date,
                (calendarDay, appointments) => new
                {
                    Timestamp = calendarDay.JsTimestamp,
                    GermanDate = calendarDay.DateTime.ToString("dd.MM.yyyy"),
                    calendarDay.DateTime.Year,
                    calendarDay.DateTime.Month,
                    calendarDay.DateTime.Day,
                    calendarDay.WeekdayNr,
                    calendarDay.WeekdayName,
                    IsWorkingDay = calendarDay.IsWorkingDayMoFr,
                    calendarDay.IsPublicHoliday,
                    PublicHolidayName = calendarDay.PublicHolidayName ?? string.Empty,
                    Appointments = appointments.Select(a => new
                    {
                        PatientFirstname = a.Patient.Firstname,
                        PatientLastname = a.Patient.Lastname,
                        PatientEmail = a.Patient.Email,
                        a.Time.TotalHours,
                        a.Time.TotalMinutes,
                        Timestamp = calendarDay.JsTimestamp + a.Time.Ticks / TimeSpan.TicksPerMillisecond,
                        Confirmed = a is ConfirmedAppointment,
                        Deleted = a is DeletedAppointment,
                        DurationMin = (a as ConfirmedAppointment)?.Duration.TotalMinutes
                    })
                });
            return Results.Ok(result);
        }
    }
}
