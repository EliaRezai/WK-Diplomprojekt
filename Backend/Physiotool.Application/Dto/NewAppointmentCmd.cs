using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physiotool.Application.Dto
{
    public record NewAppointmentCmd(
        DateTime Date,
        TimeSpan Time,
        string PatientFirstname,
        string PatientLastname,
        string PatientStreet,
        int PatientZip,
        string PatientCity,
        string PatientEmail,
        string PatientPhone);
}
