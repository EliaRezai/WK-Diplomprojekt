using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Physiotool.Application.Dto;
using Physiotool.Application.Infrastructure;
using Physiotool.Application.Model;
using System;
using System.Linq;
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
    }
}