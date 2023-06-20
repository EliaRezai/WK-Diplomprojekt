using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Physiotool.Application.Model
{
    public class AppointmentState
    {
        public AppointmentState(DateTime created)
        {
            Created = created;
        }
        public AppointmentState()
        {
            Created = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public Appointment Appointment { get; private set; } = default!;
        public DateTime Created { get; set; }
        public string Name { get; set; } = default!;
    }
}
