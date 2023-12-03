

namespace ListContact
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Contact(string name, string phone, string email, string address)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
        }
    }
}
