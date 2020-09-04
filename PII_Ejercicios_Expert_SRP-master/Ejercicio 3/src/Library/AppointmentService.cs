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
        public static string CreateAppointment()
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
           
            if (DateAndPlace.DateAndPlaceValidation() && PatientData.PatientValidation() && DoctorData.DoctorValidation())
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
