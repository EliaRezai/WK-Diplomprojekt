using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Physiotool.Application.Dto;
using Physiotool.Application.Infrastructure;
using Physiotool.Application.Model;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Physiotool.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly PhysioContext _db;

        public AppointmentController(PhysioContext context)
        {
            _db = context;
        }

        public IActionResult GetAllPatients()
        {
            return Ok(_db.Patients.ToList());
        }
        
        
        [HttpGet("available")]

        public IActionResult GetFreeAppointments([FromQuery] DateTime day)

        {

            var unconfirmedDuration = TimeSpan.FromHours(1);

            var startHour = 7.5; // Start der Ordination um 7:30

            // In a.Date steht nur der Tag (mit 0:00 als Zeit), daher vergleichen wir einmal den gesuchten Tag.

            var bookedAppointments = _db.Appointments.Include(a => a.AppointmentState)

                .Where(a => a.Date == day && !(a.AppointmentState is DeletedAppointmentState))

                .ToList();

            // Je nach State des Appointments haben wir eine definierte Dauer (Confirmed) oder wir nehmen

            // die Standarddauer.

            var appointmentTimes = bookedAppointments.Select(a => a.AppointmentState switch

            {

                ConfirmedAppointmentState s => new { Start = a.Time, End = a.Time + s.Duration },

                _ => new { Start = a.Time, End = a.Time + unconfirmedDuration }

            }).ToList();

 

            // 8 Stunden x 1/2 Stunde Raster = 16 Zeitslots

            var freeTimeslots = Enumerable.Range(0, 8 * 2)

                .Select(slot => TimeSpan.FromHours(startHour + slot / 2.0))

                // Ein Zeitslot ist frei, wenn der Start aller bestehenden Termine nachher ist

                // oder das Ende vorher ist (Intervallschachtelungsprinzip).

                .Where(time => appointmentTimes.All(aTime => aTime.End <= time || aTime.Start > time))

                .ToList();

            return Ok(freeTimeslots.Select(t => t.ToString(@"hh\:mm")));

        }
        
        
        
        
        
        
       /// [HttpGet("available")]
        ///public IActionResult GetAvailableAppointments(DateTime startDate, DateTime endDate)
       /// {
        ///    var bookedAppointments = _db.Appointments.Where(a => a.Date >= startDate && a.Date <= endDate)
            ///    .Select(a => a.Time)
             ///   .ToList();
    
           /// var availableAppointments = Enumerable.Range(8, 12)
          ///      .SelectMany(hour => new[] { 0, 30 }.
             ///       Select(minute => new TimeSpan(hour, minute, 0)))
             ///   .Where(time => !bookedAppointments.Contains(time))
            ///    .ToList();

          ///  return Ok(availableAppointments);
      ///  }
       

        

        /// <summary>
        /// Reagiert auf POST /api/appointment
        /// </summary>
        [HttpPost]
        public IActionResult AddAppointment([FromBody] NewAppointmentCmd appointmentCmd)
        {
            if (appointmentCmd.Date + appointmentCmd.Time < DateTime.Now.AddDays(1).Date)
            {
                return BadRequest("Eine Buchung ist erst für den nächsten Tag möglich.");
            }
            var patient = _db.Patients.FirstOrDefault(p =>
                p.Email == appointmentCmd.PatientEmail &&
                p.Firstname == appointmentCmd.PatientFirstname &&
                p.Lastname == appointmentCmd.PatientLastname);

            if (patient is null)
            {
                patient = new Patient(firstname: appointmentCmd.PatientFirstname,
                    lastname: appointmentCmd.PatientLastname,
                    street: appointmentCmd.PatientStreet,
                    zip: appointmentCmd.PatientZip,
                    city: appointmentCmd.PatientCity,
                    email: appointmentCmd.PatientEmail,
                    phone: appointmentCmd.PatientPhone);
                _db.Patients.Add(patient);
                _db.SaveChanges();
            }
            else
            {
                if (_db.Appointments.Any(a => a.PatientId == patient.Id
                    && a.Date == appointmentCmd.Date && a.Time == appointmentCmd.Time))
                    return BadRequest("Der Patient hat bereits einen Termin zum gleichen Datum und zur gleichen Zeit geplant.");
            }

            var appointment = new Appointment(date: appointmentCmd.Date,
                time: appointmentCmd.Time,
                patient: patient,
                created: DateTime.UtcNow,
                appointmentState: new AppointmentState(DateTime.UtcNow));
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
            return CreatedAtAction(nameof(AddAppointment), new { appointment.Guid });
        }
        [HttpDelete("{guid}")]
        public IActionResult DeleteData(Guid guid)
        {
            var data = _db.Appointments.FirstOrDefault(d => d.Guid == guid);
            if (data == null) return NotFound();
            if (data.AppointmentState is DeletedAppointmentState) { return BadRequest(); }
            data.AppointmentState = new DeletedAppointmentState();
            _db.SaveChanges();
            return Ok();
        }

        [HttpPost("{guid}")]
        public async Task<IActionResult> ConfirmAppointment(int guid, [FromBody] AppointmentState duration)
        {
            try
            {
                var appointment = await _db.Appointments.FindAsync(guid); // Ladet Termin aus der Datenbank

                if (appointment == null) // Überprüfen, ob der Termin existiert
                {
                    return NotFound(); // 404-Antwort zurück, wenn der Termin nicht gefunden wurde
                }

                appointment.AppointmentState = duration; // Festlegen der Dauer des Termins
                appointment.AppointmentState = AppointmentState.Confirmed; // AppointmentState auf Confirmed

                await _db.SaveChangesAsync(); // Speichern der Änderungen in der Datenbank

                return Ok(); // Erfolgreiche Antwort zurück
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fehler beim Bestätigen des Termins");
                return StatusCode(500); // Gibt Fehlerantwort zurück
            }
        }
    }
    }
}
