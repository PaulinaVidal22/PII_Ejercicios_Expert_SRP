
namespace AppointmentService
{
    public class Patient // Information Holder
    {
        public string Name { get; }
        public string ID { get; }
        public string PhoneNumber { get; }

        public Patient(string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
        }
    }
}