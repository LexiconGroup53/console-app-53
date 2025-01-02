using System.Text.Json;

namespace console_app;

public class LinqDemo
{
    public static int ValuableNumber = 0;

    public static int CalculateProduct(int number)
    {
        ValuableNumber++;
        Console.Write("Message");
        return ValuableNumber * number;
    }
    
    public static void FilterAge(List<Student> students)
    {
        List<int> filteredStudents = students
            .Where(s => s.Age < 30)
            .Select(s => s.Age)
            .OrderBy(s => s)
            .ToList();
        foreach (var student in filteredStudents)
        {
            Console.WriteLine(student);
        }
    }

    public static List<int> GetStudentId(List<Student> students)
    {
        return students
            .Where(s => s.City.Length == 6)
            .Select(s => s.Id)
            .ToList();
    }
    
    public static Student GetStudent(List<Student> students, int id)
    {
        return students
            .Where(s => s.Id == id)
            .SingleOrDefault();
    }
    
    public static List<int> GetAnotherStudentId(List<Student> students)
    {
        return students
            .Where(s => s.Age > 22)
            .Select(s => s.Id)
            .ToList();
    }
}