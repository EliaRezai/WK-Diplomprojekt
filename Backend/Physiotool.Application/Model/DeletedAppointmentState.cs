using System;

namespace Physiotool.Application.Model
{
    public class DeletedAppointmentState : AppointmentState
    {
        public DeletedAppointmentState(DateTime created) : base(created) { }
        public DeletedAppointmentState() : base(DateTime.UtcNow) { }
    }
}
