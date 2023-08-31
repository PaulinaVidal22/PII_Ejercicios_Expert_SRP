using System;

namespace AppointmentService
{
    public class Appointment
    {
        public string Name { get; }
        public string ID { get; }
        public string PhoneNumber { get; }
        public DateTime Date { get; }
        public string AppointmentPlace { get; }
        public string DoctorName { get; }

        public Appointment(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            Name = name;
            ID = id;
            PhoneNumber = phoneNumber;
            Date = date;
            AppointmentPlace = appointmentPlace;
            DoctorName = doctorName;
        }
    }
}