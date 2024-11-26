namespace console_app;

public class Institution
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Size { get; private set; }
    
    public Institution(int id, string name)
    {
        this.Id = id;
        this.Name = name;
        this.Size = 0;
    }
    
    public Institution(int id, string name, int size)
    {
        this.Id = id;
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