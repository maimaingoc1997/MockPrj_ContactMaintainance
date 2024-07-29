namespace TestClient.Services;

public interface IContactService
{
    Task<IEnumerable<Contact>?> GetAllContactsAsync();
    Task<Contact> GetContactByIdAsync(int id);
    Task<Contact?> CreateContactAsync(Contact contact);
    Task<Contact?> UpdateContactAsync(int id, Contact contact);
   
}