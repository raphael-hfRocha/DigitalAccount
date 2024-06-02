namespace WebApi.Models.AddCustomer;

public class AddCustomerInput
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Document { get; set; }

    public AddCustomerInput(string name, string email, string document)
    {
        Name = name;
        Email = email;
        Document = document;
    }
}
