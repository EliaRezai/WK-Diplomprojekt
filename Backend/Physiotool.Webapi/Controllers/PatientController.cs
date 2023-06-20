using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Physiotool.Application.Infrastructure;
using Physiotool.Application.Model;
using System;
using System.Linq;

namespace Physiotool.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly PhysioContext _db;
        public PatientController(PhysioContext context)
        {
            _db = context;
        }
        public IActionResult GetAllPatients()
        {
            return Ok(_db.Patients.ToList());
        }

        [HttpGet("{guid}")]
        public IActionResult GetPatient(Guid guid)
        {
            var patient = _db.Patients
                .Where(p => p.Guid == guid)
                .Select(p => new
                {
                    p.Firstname,
                    p.Lastname,
                    p.Email,
                    Appointments = p.Appointments
                        .Where(a => !(a.AppointmentState is DeletedAppointmentState))
                        .Select(a => new
                        {
                            a.Guid,
                            Confirmed = a.AppointmentState is ConfirmedAppointmentState,
                            a.Date,
                            a.Time
                        }).ToList()
                })
                .FirstOrDefault();
            if (patient is null) { return NotFound(); }
            return Ok(patient);
        }
    }
}
