namespace TestClient.Services;

public class ContactService : IContactService
{
    private readonly HttpClient _httpClient;
    private readonly string? _baseUrl;

    public ContactService(IConfiguration configuration, HttpClient httpClient)
    {
        _httpClient = httpClient;
        _baseUrl = configuration["ApiSettings:BaseUrl"];
    }

    public async Task<IEnumerable<Contact>?> GetAllContactsAsync()
    {
        var response = await _httpClient.GetAsync($"{_baseUrl}contacts");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<Contact>>();
    }

    public async Task<Contact> GetContactByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync($"{_baseUrl}contacts/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Contact>();
    }

    public async Task<Contact?> CreateContactAsync(Contact contact)
    {
        var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}contacts", contact);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Contact>();
    }

    public async Task<Contact?> UpdateContactAsync(int id, Contact contact)
    {
        var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}contacts/{id}", contact);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Contact>();
    }

    public async Task DeleteContactAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"{_baseUrl}contacts/{id}");
        response.EnsureSuccessStatusCode();
    }
}