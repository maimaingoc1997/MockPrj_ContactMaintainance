using ContactMaintainenceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactMaintainenceAPI.Controllers;
[Route("api/[controller]")]
public class ContactsController : Controller
{
    private readonly ContactService _contactService;

    public ContactsController(ContactService contactService)
    {
        _contactService = contactService;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contact>>> GetAllContacts()
    {
        return Ok(await _contactService.GetAllContactsAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Contact>> GetContactById(int id)
    {
        var contact = await _contactService.GetContactByIdAsync(id);
        if (contact == null)
        {
            return NotFound();
        }

        return Ok(contact);
    }

    [HttpPost]
    public async Task<ActionResult> AddContact([FromBody] Contact contact)
    {
        await _contactService.AddContactAsync(contact);
        return CreatedAtAction(nameof(GetContactById), new { id = contact.Id }, contact);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContact(int id, [FromBody] Contact contact)
    {
        if (id != contact.Id)
        {
            return BadRequest();
        }

        await _contactService.UpdateContactAsync(contact);
        return NoContent();
    }

}