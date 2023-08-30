using System;
using System.Text;

namespace AppointmentService
{
    public class AppointmentSchedule
    {
        public static string Schedule (bool isValid)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            
            if (isValid)
            {
                stringBuilder.Append("Appointment scheduled");
            }
            else {
                stringBuilder.Append("Unable to schedule appointment");

            }
            return stringBuilder.ToString();
        }
    }
}
