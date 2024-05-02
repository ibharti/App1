using BlazorApp.Models;

namespace BlazorApp
{
    public interface IContactService
    {
        List<Contact> GetContacts();
       void AddContact(Contact contact);
    }
}
