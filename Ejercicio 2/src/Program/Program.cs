using System;
using AppointmentService;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool validation1 = AppointmentDataValidation.ValidateData("Steven Jhonson", "986782342", "5555-555-555", "Wall Street", "Armand");
            string appointmentResult = AppointmentSchedule.Schedule(validation1);
            Console.WriteLine(appointmentResult);

            bool validation2 = AppointmentDataValidation.ValidateData("Ralf Manson", "", "5555-555-555", "Queen Street", "");
            string appointmentResult2 = AppointmentSchedule.Schedule(validation2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
