namespace BT_Widgets.Mvc.Models.ContactUs
{
    public class ContactUsViewModel
    {
        public string Link { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
       
        public string Company { get; set; }
       
        public string Email { get; set; }

        public string Message { get; set; }

        public bool SalesSupport { get; set; }

        public bool CustomerSupport { get; set; }

        public bool Agreetorecievenews { get; set; }
    }
}
