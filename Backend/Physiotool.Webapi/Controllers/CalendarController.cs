using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Physiotool.Application.Infrastructure;
using Physiotool.Application.Model;
using Physiotool.Application.Services.HolidayCalendar;
using System;
using System.Linq;

namespace Physiotool.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
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
        public IActionResult GetCalendar(int year, int month)
        {
            var defaultDuration = TimeSpan.FromHours(1);
            var calendarDays = _calendarService.GetDaysOfMonthFullWeeks(year, month);
            var appointments = _db.Appointments.Include(a => a.Patient).Include(a => a.AppointmentState)
                .Where(a => a.Date.Month == month && a.Date.Year == year)
                .ToList()
                .OrderBy(a => a.Date).ThenBy(a => a.Time)
                .ToList();
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
                    SchoolHolidayName = calendarDay.SchoolHolidayName ?? string.Empty,
                    Appointments = appointments.Select(a => new
                    {
                        a.Guid,
                        PatientFirstname = a.Patient.Firstname,
                        PatientLastname = a.Patient.Lastname,
                        PatientEmail = a.Patient.Email,
                        Timestamp = calendarDay.JsTimestamp + a.Time.TotalMilliseconds,
                        Confirmed = a.AppointmentState is ConfirmedAppointmentState,
                        Deleted = a.AppointmentState is DeletedAppointmentState,
                        (a.AppointmentState as ConfirmedAppointmentState)?.Duration,
                        End = calendarDay.JsTimestamp + a.Time.TotalMilliseconds +
                            ((a.AppointmentState as ConfirmedAppointmentState)?.Duration.TotalMilliseconds ?? defaultDuration.TotalMilliseconds),
                        (a.AppointmentState as ConfirmedAppointmentState)?.Infotext
                    })
                });
            return Ok(result);
        }
    }
}
