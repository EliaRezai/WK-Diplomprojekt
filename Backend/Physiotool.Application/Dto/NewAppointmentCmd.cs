using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Physiotool.Application.Dto
{
    public record NewAppointmentCmd(
        DateTime Date,
        TimeSpan Time,
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Ungültiger Vorname")] string PatientFirstname,
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Ungültiger Nachname")] string PatientLastname,
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Ungültige Straße")] string PatientStreet,
        [Range(1000, 9999, ErrorMessage = "Ungültige Postleitzahl")] int PatientZip,
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Ungültige Stadt")] string PatientCity,
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Ungültige Email Adresse")]
        [EmailAddress(ErrorMessage = "Ungültige Email Adresse")]
        string PatientEmail,
        [RegularExpression(@"^\+?[0-9 \-]{2,}$", ErrorMessage ="Ungültige Telefonnummer")]
        string PatientPhone);
}