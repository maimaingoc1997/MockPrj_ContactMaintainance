using ContactMaintainenceAPI.Repositories;

namespace ContactMaintainenceAPI.Services;

public class ContactService
{
    private readonly IContactRepository _contactRepository;

    public ContactService(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<IEnumerable<Contact>> GetAllContactsAsync()
    {
        return await _contactRepository.GetAllContacts();
    }

    public async Task<Contact?> GetContactByIdAsync(int id)
    {
        return await _contactRepository.GetContactById(id);
    }

    public async Task AddContactAsync(Contact contact)
    {
        await _contactRepository.AddContact(contact);
    }

    public async Task UpdateContactAsync(Contact contact)
    {
        await _contactRepository.UpdateContact(contact);
    }

   
}
