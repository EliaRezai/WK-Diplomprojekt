using System;

namespace Physiotool.Application.Model
{
    public class ConfirmedAppointmentState : AppointmentState
    {
#pragma warning disable CS8618

        protected ConfirmedAppointmentState()
        { }

#pragma warning restore CS8618

        public ConfirmedAppointmentState(DateTime created, TimeSpan duration, string? infotext = null) : base(created)
        {
            Duration = duration;
            Infotext = infotext;
        }

        public ConfirmedAppointmentState(TimeSpan duration, string? infotext = null) : this(DateTime.UtcNow, duration, infotext)
        {
        }

        public TimeSpan Duration { get; set; }
        public string? Infotext { get; set; }
    }
}