namespace console_app;

public class Institution
{
    public int InstitutionId { get; set; }
    public string Name { get; set; }
    public int Size { get; private set; }
    public List<Course> Courses { get; set; }
    
    public Institution(string name)
    {
        this.Name = name;
        this.Size = 0;
    }
    
    public Institution(string name, int size)
    {
        this.Name = name;
        this.Size = size;
    }

    public bool ChangeSize(int newSize)
    {
        if (newSize > 0)
        {
            this.Size = newSize;
            return true;
        }

        return false;
    }
}