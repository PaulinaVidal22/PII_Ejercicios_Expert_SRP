using System;

namespace AppointmentService
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Steven Johnson";
            string id = "986782342";
            string phoneNumber = "5555-555-555";
            DateTime date = DateTime.Now;
            string appointmentPlace = "Wall Street";
            string doctorName = "Armand";

            Patient patient1 = new Patient(name, id, phoneNumber);
            AppointmentData appointment1 = new AppointmentData(date, appointmentPlace, Guid.NewGuid().ToString());
            DoctorData doctor1 = new DoctorData(doctorName, "Specialization");

            (bool isValid1, string errorMessages1) validationResult1 = AppointmentValidation.ValidateData(patient1, appointment1, doctor1);

            string result1 = AppointmentScheduleMessage.ScheduleAppointment(validationResult1.isValid1, validationResult1.errorMessages1, patient1, appointment1, doctor1);

            Console.WriteLine(result1);

            string name2 = "Ralf Manson";
            string id2 = "";
            string phoneNumber2 = "5555-555-555";
            DateTime date2 = DateTime.Now;
            string appointmentPlace2 = "Queen Street";
            string doctorName2 = "";

            Patient patient2 = new Patient(name2, id2, phoneNumber2);
            AppointmentData appointment2 = new AppointmentData(date2, appointmentPlace2, Guid.NewGuid().ToString());
            DoctorData doctor2 = new DoctorData(doctorName2, "Specialization");

            (bool isValid2, string errorMessages2) validationResult2 = AppointmentValidation.ValidateData(patient2, appointment2, doctor2);

            string result2 = AppointmentScheduleMessage.ScheduleAppointment(validationResult2.isValid2, validationResult2.errorMessages2, patient2, appointment2, doctor2);

            Console.WriteLine(result2);
        }
    }
}
            




