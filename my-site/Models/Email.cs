namespace my_site.Models
{
    public class Email
    {
        public string emailBody { get; set; }
        public string recipientsName { get; set; }
        public string recipientsEmailAddress { get; set; }
        public string sendersName { get; set; }
        public string sendersEmailAddress { get; set; }
        public string subject { get; set; }
        public string host { get; set; }
        public int port { get; set; }
        public bool useSSL { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
