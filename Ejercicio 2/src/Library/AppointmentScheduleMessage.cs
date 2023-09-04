using System;
using System.Text;

namespace AppointmentService
{
    public class AppointmentScheduleMessage //Service Provider
    {
        public static string ScheduleAppointment(bool isValid, string errorMessages, Patient patient, AppointmentData appointment, DoctorData doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (isValid)
            {
                Appointment appointmentInstance = new Appointment(patient, appointment, doctor);

                stringBuilder.Append($"Appointment scheduled for {appointmentInstance.AppointmentInfo.Date.ToShortDateString()} at {appointmentInstance.AppointmentInfo.AppointmentPlace} with Dr. {appointmentInstance.DoctorInfo.DoctorName}");

            }
            else
            {
                stringBuilder.Append("Unable to schedule appointment due to the following errors:\n");
                stringBuilder.Append(errorMessages);
            }
            return stringBuilder.ToString();
        }
    }
}
