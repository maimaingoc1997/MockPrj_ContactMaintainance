using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ContactMaintainenceAPI;

public class ContactService
{
    private readonly HttpClient _httpClient;

    public ContactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:5237/");
    }

    public async Task<List<Contact>> GetContactsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Contact>>("api/Contacts");
    }
    // Các phương thức thêm, sửa, xóa tương tự
}