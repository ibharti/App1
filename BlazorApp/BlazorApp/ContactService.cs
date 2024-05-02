using BlazorApp.Models;

namespace BlazorApp
{
    public class ContactService : IContactService //inherting the interface
    {
        private List<Contact> contactList = new List<Contact>();
        public List<Contact> GetContacts()
        {
            return contactList;
        }
        public void AddContact (Contact contact)
        {
            contactList.Add(contact);
        }
    }
}
