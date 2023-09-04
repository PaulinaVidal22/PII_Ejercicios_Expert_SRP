namespace AppointmentService
{
    public class DoctorData //Information Holder
    {
        public string DoctorName { get; }
        public string Specialization { get; }

        public DoctorData(string doctorName, string specialization)
        {
            this.DoctorName = doctorName;
            this.Specialization = specialization;
        }
    }
}