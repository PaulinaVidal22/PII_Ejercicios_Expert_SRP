using System;

namespace AppointmentService
{
    public class AppointmentData //Information Holder
    {

        public DateTime Date { get; }
        public string AppointmentPlace { get; } 

        public string AppointmentId {get; set;} 

        public AppointmentData(DateTime date, string appointmentPlace, string appointmentId)
        {

            this.Date = date;
            this.AppointmentPlace = appointmentPlace;
            this.AppointmentId = appointmentId; 
            appointmentId = Guid.NewGuid().ToString();
        }
    }
}