using Microsoft.EntityFrameworkCore;

namespace ContactMaintainenceAPI.Data;

public class ContactDbContext : DbContext
{
   
    public ContactDbContext(DbContextOptions options) : base(options)
    {
    }
    //muoosn sử dụng 1 hàm contructor hàm khởi tạo, 
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<MagagerName> MagagerNames { get; set; }
}