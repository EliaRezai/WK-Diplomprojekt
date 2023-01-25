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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; private set; } = default!;
        public DateTime Created { get; set; }
    }
}
