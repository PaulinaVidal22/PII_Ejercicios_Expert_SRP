using System;


namespace AppointmentService
{
    public class AppointmentDataValidation
    {
        public static bool ValidateData(string name, string id, string phoneNumber, string appointmentPlace, string doctorName)
        {
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {

                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                isValid = false;
            }

            return isValid;
        }
        
    }
}
