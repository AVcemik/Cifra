using System.Xml.Serialization;

namespace UserAccount
{
    [Serializable]
    public class User
    {
        public uint Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public ushort Age { get; set; }
        public bool IsAdmin { get; set; }
    }
}
