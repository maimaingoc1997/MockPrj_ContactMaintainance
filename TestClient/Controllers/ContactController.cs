using Microsoft.AspNetCore.Mvc;
using TestClient.Services;

namespace TestClient.Controllers;

public class ContactController : Controller
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    public async Task<IActionResult> Index()
    {
        var contacts = await _contactService.GetAllContactsAsync();
        return View(contacts);
    }

    public async Task<IActionResult> Details(int id)
    {
        var contact = await _contactService.GetContactByIdAsync(id);
        return View(contact);
    }
    //
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    //
    // [HttpPost]
    // public async Task<IActionResult> Create(Contact contact)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         await _contactService.CreateContactAsync(contact);
    //         return RedirectToAction(nameof(Index));
    //     }
    //     return View(contact);
    // }

    // Thêm các action khác cho Edit và Delete nếu cần
}