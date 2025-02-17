namespace console_app;

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public List<Student> Students { get; set; }

    public int InstitutionId { get; set; }
    public Institution Institution { get; set; }
}