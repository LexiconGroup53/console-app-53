namespace console_app;

public class Person
{
    /*
     private string firstName;
    
    private string lastName;

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }
    
    public string GetFirstName()
    {
        return this.firstName;
    }
    
    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string GetLastName()
    {
        return this.lastName;
    }
    */
    
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()
    {
        
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string GetFullName()
    {
        return this.LastName + ", " + this.FirstName;
    }
}