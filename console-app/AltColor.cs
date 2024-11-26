namespace console_app;

public class AltColor
{
    public string Color { get; private set; }

    public void SetToGreen()
    {
        Color = "Green";
    }
    
    public void SetToRed()
    {
        Color = "Red";
    }
    
    public void SetToBlue()
    {
        Color = "Blue";
    }
}