namespace console_app;

public class IterationDemo
{
    // for 
    // foreach
    // while
    // do-while
    
    public static string[] UseWhile()
    {
        int counting = 9;
        string[] result = new string[9];
        while (counting > 0)
        {
            result[9 - counting] = "Text " + counting--;
        }
        return result;
    }

    public static int UseDoWhile()
    {
        bool inValidEntry = true;
        string entry = "";
        int counterTrial = 0;
        do
        {
            entry = Console.ReadLine();
            if (entry.Length > 2) inValidEntry = false;
            counterTrial++;
        } while (inValidEntry && counterTrial < 4);

        return entry.Length;
    }
    
}