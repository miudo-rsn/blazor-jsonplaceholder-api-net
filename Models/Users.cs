namespace BlazorUsersJsonPlaceHolderApi.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Username { get; set; } = "";
    public string Email { get; set; } = "";
    public Address Address { get; set; } = new();
    public Company Company { get; set; } = new();
}

public class Address
{
    public string Street { get; set; } = "";
    public string City { get; set; } = "";
}

public class Company
{
    public string Name { get; set; } = "";
}