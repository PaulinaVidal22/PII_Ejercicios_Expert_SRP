using System.Text;

namespace AppointmentService
{
    public class AppointmentValidation // Service Provider
    {
        public static (bool isValid, string errorMessages) ValidateData(Patient patient, AppointmentData appointment, DoctorData doctor)
        {
            StringBuilder errorMessages = new StringBuilder();
            bool isValid = true;

            if (string.IsNullOrEmpty(patient.Name))
            {
                errorMessages.Append("Patient name is required.\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.ID))
            {
                errorMessages.Append("Patient ID is required.\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.PhoneNumber))
            {
                errorMessages.Append("Patient phone number is required.\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.AppointmentPlace))
            {
                errorMessages.Append("Appointment place is required.\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.DoctorName))
            {
                errorMessages.Append("Doctor name is required.\n");
                isValid = false;
            }

            return (isValid, errorMessages.ToString());
        }
    }
}