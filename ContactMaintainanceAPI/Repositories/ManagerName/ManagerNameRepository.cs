using ContactMaintainenceAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactMaintainenceAPI.Repositories.ManagerName;

public class ManagerNameRepository : IManagerNameRepository
{
    private readonly ContactDbContext _context;

    public ManagerNameRepository(ContactDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<MagagerName>> GetAddManagerName()
    {
        return await _context.MagagerNames.ToListAsync();
    }

    public async Task<MagagerName?> GetManagerNameById(int id)
    {
        return await _context.MagagerNames.FindAsync(id);
    }
}