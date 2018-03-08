using System.Collections.Generic;

namespace Certifications.Data.Models
{
    public class Administrator
    {
        public int AdministraorID { get; set; }
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Server> Servers { get; set; }
    }
}