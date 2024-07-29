using ContactMaintainenceAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactMaintainenceAPI.Repositories.contact;

public class ContactRepository:IContactRepository
{
    private readonly ContactDbContext _context;

    public ContactRepository(ContactDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Contact>> GetAllContacts()
    {
        
        return await _context.Contacts.ToListAsync();
    }

    public async Task<Contact?> GetContactById(int id)
    {
        return await _context.Contacts.FindAsync(id);
    }

    public async Task AddContact(Contact contact)
    {
        await _context.Contacts.AddAsync(contact);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateContact(Contact contact)
    {
         _context.Contacts.Update(contact);
         await _context.SaveChangesAsync();
    }
}