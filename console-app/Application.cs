namespace console_app;

public class Application
{
    public Person Person { get; set; }
    public List<string> Interests { get; set; }

    public Application()
    {
        
    }

    public Application(Person person, List<string> interests)
    {
        Person = person;
        Interests = interests;
    }
}