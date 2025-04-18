using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class ContactViewModel
    {

        private List<ContactInfo> _contact = new List<ContactInfo>
        {
            new ContactInfo
            {
                Address = "Tanta, Egypt",
                Phone = "+201128411383",
                Email = "renadalshooni@gmail.com"
            }
        };

        public List<ContactInfo> Contact => _contact;

    }
}
