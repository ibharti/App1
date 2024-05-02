using BlazorApp.Models;

namespace BlazorApp
{
    public class ContactServiceTesting : IContactService
    {
        private List<Contact> contactList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        
        }
        public List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact
                {
                    FirstName = "Test",
                    LastName = "Testing",
                    Email = "test@gmail.com"
                }
            };
        }
    }
}
