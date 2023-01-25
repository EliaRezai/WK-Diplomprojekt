using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Physiotool.Application.Model
{
    [Table("Patient")]
    public class Patient
    {
        public Patient(string firstname, string lastname, string street, int zip, string city, string email, string phone)
        {
            Firstname = firstname;
            Lastname = lastname;
            Street = street;
            Zip = zip;
            City = city;
            Email = email;
            Phone = phone;
        }
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected Patient() { }
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Key]
        public int Id { get; private set; }
        [MaxLength(255)]
        public string Firstname { get; set; }
        [MaxLength(255)]
        public string Lastname { get; set; }
        [MaxLength(255)]
        public string Street { get; set; }
        public int Zip { get; set; }
        [MaxLength(255)]
        public string City { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(255)]
        public string Phone { get; set; }
        public List<Appointment> Appointments { get; } = new();
    }
}
