using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Physiotool.Application.Infrastructure;
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
        public IResult GetAllPatients()
        {
            return Results.Ok(_db.Patients.ToList());
        }
    }
}
