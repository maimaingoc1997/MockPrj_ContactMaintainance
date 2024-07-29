using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ContactsController : Controller
{
    private readonly ContactService _contactService;

    public ContactsController(ContactService contactService)
    {
        _contactService = contactService;
    }

    public async Task<IActionResult> Index()
    {
        var contacts = await _contactService.GetContactsAsync();
        return View(contacts);
    }

    // Các phương thức thêm, sửa, xóa tương tự
}