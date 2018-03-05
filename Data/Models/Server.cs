namespace Certifications.Data.Models
{
    public class Server
    {
        public int ServerID { get; set; }

        public string ConnectionString { get; set; }

        public ServerType ServerType { get; set; }
    }
}