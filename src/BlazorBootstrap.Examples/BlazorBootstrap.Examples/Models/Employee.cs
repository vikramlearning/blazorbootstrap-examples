namespace BlazorBootstrap.Examples;

public class Employee
{
    public int Id { get; init; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Company { get; set; } = default!;
    public string Designation { get; set; } = default!;
    public DateOnly DOJ { get; set; }
    public decimal Salary { get; set; }
    public bool IsActive { get; set; }
}
