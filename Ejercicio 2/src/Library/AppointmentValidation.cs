using System;
using System.Text;


namespace AppointmentService
{
    public class AppointmentValidation
    {
        public static (bool isValid, string errorMessages) ValidateData(string name, string id, string phoneNumber,DateTime date, string appointmentPlace, string doctorName)
        {
            StringBuilder errorMessages = new StringBuilder();
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                errorMessages.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                errorMessages.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                errorMessages.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                errorMessages.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                errorMessages.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }
            return (isValid, errorMessages.ToString());
        }

    }
}
        
