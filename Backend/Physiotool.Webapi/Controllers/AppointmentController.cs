using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Physiotool.Application.Infrastructure;
using System;
using System.Linq;
using System.Text.Json.Nodes;

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

        [HttpPost("/api/appointment")]
        public String Test(String name)
        {
            return "hello world"+name;
        }
    }
}