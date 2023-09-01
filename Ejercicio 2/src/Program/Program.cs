using System;
using System.Text;

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

            (bool isValid, string errorMessages) validationResult1 = AppointmentValidation.ValidateData(name, id, phoneNumber, date, appointmentPlace, doctorName);

            StringBuilder stringBuilder = new StringBuilder();
            string result1 = AppointmentScheduleMessage.ScheduleAppointment(validationResult1.isValid, validationResult1.errorMessages, name, id, phoneNumber, date, appointmentPlace, doctorName);

            Console.WriteLine(result1);
            
            string name2 = "Ralf Manson";
            string id2 = "";
            string phoneNumber2 = "5555-555-555";
            DateTime date2 = DateTime.Now;
            string appointmentPlace2 = "Queen Street";
            string doctorName2 = "";

            (bool isValid2, string errorMessages2) validationResult2 = AppointmentValidation.ValidateData(name, id2, phoneNumber2, date2, appointmentPlace2, doctorName2);

            StringBuilder stringBuilder2 = new StringBuilder();
            string result2 = AppointmentScheduleMessage.ScheduleAppointment(validationResult2.isValid2, validationResult2.errorMessages2, name2, id2, phoneNumber2, date2, appointmentPlace2, doctorName2);

            Console.WriteLine(result2);

            
        }
    }
}
            
            




