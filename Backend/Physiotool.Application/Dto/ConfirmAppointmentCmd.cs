using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Physiotool.Application.Dto
{
    public record ConfirmAppointmentCmd(Guid Guid, TimeSpan Duration, string? Infotext) : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Duration == default || Duration > TimeSpan.FromHours(24))
                yield return new ValidationResult("Invalid duration.", new string[] { nameof(Duration) });
        }
    }
}