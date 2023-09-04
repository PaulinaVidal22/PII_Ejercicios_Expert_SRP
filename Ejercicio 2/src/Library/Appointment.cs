
namespace AppointmentService
{
    public class Appointment // Coordinator
    {
        public Patient PatientInfo { get; }
        public AppointmentData AppointmentInfo { get; }
        public DoctorData DoctorInfo { get; }

        public Appointment(Patient patient, AppointmentData appointment, DoctorData doctor)
        {
            this.PatientInfo = patient;
            this.AppointmentInfo = appointment;
            this.DoctorInfo = doctor;
        }
    }
}