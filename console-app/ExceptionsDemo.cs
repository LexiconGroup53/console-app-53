namespace console_app;

public class ExceptionsDemo
{
    public static int GetNumberWithCatch()
    {
        string number = "";
        int actualNumber = -1;
        bool wrongContent = true;
        while (wrongContent)
        {
            number = Console.ReadLine();
            try
            {
                actualNumber = int.Parse(number);
                wrongContent = false;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    
        Console.WriteLine("Back in method");
        return actualNumber;
    }

    public static int CallMethod()
    {
        try
        {
            return GetNumber();
        }
        finally
        {
            Console.WriteLine("In additional method");
        }

        return 91;
    }
    
    public static int GetNumber()
    {
        string number = Console.ReadLine();;
        int actualNumber = -1;

        try
        {
            actualNumber = int.Parse(number);
        }
        finally
        {
            Console.WriteLine("This must be a number");
        }
        Console.WriteLine("Back in method");
        return actualNumber;
    }
}