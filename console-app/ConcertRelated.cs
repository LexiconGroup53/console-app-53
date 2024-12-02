namespace console_app;

public class ConcertRelated
{
    public static void UseList()
    {
        List<string> words = new List<string>();
        words.Add("Real");
        words.Add("For");

        foreach (string item in words)
        {
            Console.WriteLine(item);
        }
    }

    public static void UseParse()
    {
        string textValue = Console.ReadLine();
        int numberValue;
        bool didWork = int.TryParse(textValue, out numberValue);
        if(didWork) Console.WriteLine(numberValue);
        numberValue = int.Parse(textValue);
        Console.WriteLine(numberValue);
    }
    
}