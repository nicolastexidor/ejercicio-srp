using System;
using System.Text;
//Creo que esta clase no cumple tanto con srp como con expert ya que conoce demasiadas cosas y tiene demasiadas verificaciones.
//Se podría crear 3 clases distintas, una para los datos del paciente (PatientData), otra para los datos del doctor (DoctorData) y una tercera que contenga la fecha y lugar (DateAndPlace).
//Cada una de estas clases debería verificar si los datos ingresados son válidos.
//Teniendo las clases mencionadas, AppointmentService podría colaborar con ellas, y, si no hay ningun valor inválido devolver "Appointment shceduled".
//De esta forma se podrá agregar datos a cada clase si es necesario, como la edad en el paciente, la especialidad del doctor o la sucursal.
namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
