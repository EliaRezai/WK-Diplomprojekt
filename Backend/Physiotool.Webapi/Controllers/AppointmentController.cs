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
        /// <param name="appointmentCmd"></param>
        /// <returns></returns>
        [HttpPost]

        public IActionResult AddAppointment(NewAppointmentCmd appointmentCmd)
        {
            var patient = _db.Patients.FirstOrDefault(p =>
                p.Email == appointmentCmd.PatientEmail && p.Firstname == appointmentCmd.PatientFirstname &&
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
                try { _db.SaveChanges(); }
                catch (DbUpdateException e) { return BadRequest(e.InnerException?.Message ?? e.Message); }
            }
            var appointment = new Appointment(date: appointmentCmd.Date,
                time: appointmentCmd.Time,
                patient: patient,
                created: DateTime.UtcNow,
                appointmentState: new AppointmentState(DateTime.UtcNow));
            _db.Appointments.Add(appointment);
            try { _db.SaveChanges(); }
            catch (DbUpdateException e) { return BadRequest(e.InnerException?.Message ?? e.Message); }
            return CreatedAtAction(nameof(AddAppointment), new { appointment.Guid });
        }
    }
}