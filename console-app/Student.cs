using System.ComponentModel.DataAnnotations;

namespace console_app;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    public int PersonId { get; set; }
    public Person Person { get; set; }

    public List<Course> Courses { get; set; }
    
    
    public string Email { get; set; }
    public string Language { get; set; }
   
    public string City { get; set; }
}