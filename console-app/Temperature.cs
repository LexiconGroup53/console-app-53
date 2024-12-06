namespace console_app;

public class Temperature
{
    public double Degree { get; private set; }
    public TempSystem System { get; private set; }

    public enum TempSystem
    {
        Fahrenheit,
        Celsius
    }
    public static bool Intitialize(string text, out Temperature temperature)
    {
        temperature = new Temperature();
        bool successful = false;
        string[] twoValues = text.Split('°');
        if (twoValues.Length < 2) return false;
        if (twoValues[1].Equals("C"))
        {
            temperature.System = TempSystem.Celsius;
            successful = true;
        }
        else if (twoValues[1].Equals("F"))
        {
             temperature.System = TempSystem.Fahrenheit;
             successful = true;
        }
        if (successful) return true;
        return false;
    }
}