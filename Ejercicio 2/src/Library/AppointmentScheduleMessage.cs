using System;
using System.Text;

namespace AppointmentService
{
    public class AppointmentScheduleMessage
    {
        public static string ScheduleAppointment (bool isValid, StringBuilder stringBuilder, string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            
            if (isValid)
            {
                Appointment appointment = new Appointment(name, id, phoneNumber, date, appointmentPlace, doctorName);

                stringBuilder.Append($"Appointment scheduled for {date.ToShortDateString()} at {appointmentPlace} with Dr. {doctorName}");

            } else{
                
            }
            return stringBuilder.ToString();
        }
    }
}
