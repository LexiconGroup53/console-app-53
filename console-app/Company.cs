namespace console_app;

public class Company
{
    public string Brand { get; set; }
    public string Address { get; set; }
    public int YearFounded { get; set; }
    public Person CEO { get; set; }

    public string GetPhrase()
    {
        return "Our CEO is " + CEO.FirstName + " " + CEO.LastName;
    }
}