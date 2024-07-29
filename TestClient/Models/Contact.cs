using System.ComponentModel.DataAnnotations;

namespace TestClient;

public class Contact
{
    public int Id { get; set; }

    [Required] public string Firstname { get; set; }

    [Required] public string Surname { get; set; }

    public string KnowAs { get; set; }
    public string OfficePhone { get; set; }
    public string MobilePhone { get; set; }
    public string StHomePhone { get; set; }

    [EmailAddress] public string EmailAddress { get; set; }

    public MagagerName ManagerName { get; set; }

    [Required] public string ContactType { get; set; }

    public string BestContactMethod { get; set; }
    public string JobRole { get; set; }
    public string Workbase { get; set; }
    public string JobTitle { get; set; }

    public bool IsActive { get; set; }

    
    //cho truy vấn ( tính đóng gói) lấy ra v nhập vào thuộc tính
}