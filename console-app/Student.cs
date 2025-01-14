using System.ComponentModel.DataAnnotations;

namespace console_app;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Language { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}