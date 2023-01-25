using System;

namespace Physiotool.Application.Model
{
    public class ConfirmedAppointmentState : AppointmentState
    {
#pragma warning disable CS8618
        protected ConfirmedAppointmentState() { }
#pragma warning restore CS8618

        public ConfirmedAppointmentState(DateTime created, TimeSpan duration) : base(created)
        {
            Duration = duration;
        }
        public ConfirmedAppointmentState(TimeSpan duration) : this(DateTime.UtcNow, duration) { }
        public TimeSpan Duration { get; set; }
    }
}
