namespace Lessons1.Infrastructure
{
    public class AppConfig
    {
        public TinyMCE TinyMce { get; set;  } =  new TinyMCE();
        public Company Company { get; set; } = new Company();

    }

    public class TinyMCE
    {
        public string? ApiKey { get; set; }

    }

    public class Company
    {
        public string? Companyname { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyEmail { get; set; }
    }
}
