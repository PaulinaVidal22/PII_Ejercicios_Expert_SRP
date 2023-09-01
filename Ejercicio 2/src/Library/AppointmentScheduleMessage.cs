using System;
using System.Text;

namespace AppointmentService
{
    public class AppointmentScheduleMessage
    {
        public static string ScheduleAppointment (bool isValid, string errorMessages, string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (isValid)
            {
                Appointment appointment = new Appointment(name, id, phoneNumber, date, appointmentPlace, doctorName);

                stringBuilder.Append($"Appointment scheduled for {date.ToShortDateString()} at {appointmentPlace} with Dr. {doctorName}");

            } else{
                stringBuilder.Append("Unable to schedule appointment due to the following errors:\n");
                stringBuilder.Append(errorMessages);
                    }
            return stringBuilder.ToString();
        }
    }
}
