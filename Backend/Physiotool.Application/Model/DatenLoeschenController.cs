using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Physiotool.Application.Infrastructure;

namespace Physiotool.Application.Model
{
    
        public class DatenLoeschenController : ControllerBase
        {
            private readonly PhysioContext _db;

            public DatenLoeschenController(PhysioContext context)
            {
                _db = context;
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteData(int id)
            {
                var data = _db.Appointments.FirstOrDefault(d => d.Id == id);

                if (data == null)
                {
                    return NotFound();
                }

                _db.Appointments.Remove(data);
                _db.SaveChanges();

                return Ok();
            }
        }
    }