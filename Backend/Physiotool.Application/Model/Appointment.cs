using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Physiotool.Application.Model
{
    /// <summary>
    /// Der Termin des Patienten.
    /// </summary>
    [Table("Appointment")]
    public class Appointment
    {
        public Appointment(DateTime date, TimeSpan time, Patient patient, DateTime created, AppointmentState appointmentState)
        {
            Date = date.Date;
            Time = time;
            PatientId = patient.Id;
            Patient = patient;
            Created = created;
            AppointmentState = appointmentState;
        }
#pragma warning disable CS8618
        protected Appointment() { }
#pragma warning restore CS8618
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime Created { get; set; }
        public int AppointmentStateId { get; set; }
        public AppointmentState AppointmentState { get; set; }

    }
    
    
    
    
    
}
