using BlazorApp.Models;

namespace BlazorApp
{
    public class ContactService
    {
        public List<Contact> ContactList = new List<Contact>();
        public void AddContact (Contact contact)
        {
            ContactList.Add(contact);
        }
    }
}
