
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Physiotool.Application.Model
{
    /// <summary>
    /// Der Termin des Patienten.
    /// </summary>
    [Table("OpeningHour")]
    public class OpeningHour{


        //public openinghour(dayofweek dayofweek, decimal from, decimal to)
        //{
        //    dayofweek = dayofweek.dayofweek;
        //    from = from.from;
        //    to = to.to;

        //}

#pragma warning disable CS8618
        protected OpeningHour() { }
        #pragma warning restore CS8618

        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int weekoftheday { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        public decimal From { get; set; }
        public decimal To { get; set; }

        [ForeignKey("Physio")]
        public int PhysioId { get; set; }
        public Physio Physio { get; set; }  


        
    }
}

