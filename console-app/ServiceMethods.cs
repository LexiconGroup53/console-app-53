using System.Threading.Channels;

namespace console_app;

public class ServiceMethods
{
    private static int luggagePenalty = 35;
    public static string GetFullName(string firstName, string lastName)
    {
        return lastName + ", " + firstName;
    }
    
    public static string GetFullName(string firstName, char initial, string lastName)
    {
        return lastName + ", " + firstName + " " + initial;
    }
    
    public  double DivideNumbers(int number1, int number2)
    {
        return (double) number1 / number2;
    }
    
    public static string ReturnMary()
    {
        return "Mary";
    }

    public static void LoopWithMultiplication()
    {
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine(i * 7);
        }
    }

    public static void LoopWithNestedLoop()
    {
        for (int i = 1; i < 6; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("B");
            }
            Console.WriteLine(i + 3);
        }
    }
    
    public static void LoopWithNestedLoopAlternative()
    {
        for (int i = 1; i < 6; i++)
        {
            string snippet = "";
            for (int j = 0; j < i; j++)
            {
                snippet = snippet + "B";
            }
            Console.WriteLine(snippet + (i + 3));
        }
    }
    
    public static double CalculateAverage(int number1, int number2, int number3)
    {
        return (double) (number1 + number2 + number3) / 3;
    }

    public static int GetLowest(int number1, int number2)
    {
        return number1 < number2 ? number1 : number2;
    }

    public static double CalculateAverageDifference(int number1, int number2, int number3)
    {
        double average = CalculateAverage(number1, number2, number3);
        double difference = 0;
        difference += (double) average <= number1 ? number1 - average : average - number1;
        difference += (double) average <= number2 ? number2 - average : average - number2;
        difference += (double) average <= number3 ? number3 - average : average - number3;
        return difference;
        
    }

    // 5 kilo carry on luggage
    // 15 kilo bag
    // Penalty for additional bag 45 SEK
    // Penalty for additional kilos per kilo 35 SEK
    public static int CalculatePenalty(int carryOn, int bag1, int bag2, int bag3)
    {
        int penalty = 0;
        penalty += carryOn > 5 ? (carryOn - 5) * luggagePenalty : 0;
        if (bag2 == 0 && bag3 == 0)
        {
            penalty += bag1 > 15 ? (bag1 - 15) * luggagePenalty : 0;
        } 
        else if (bag2 > 0 && bag3 == 0)
        {
            penalty = 45;
            penalty += ( bag1 + bag2 ) > 15 ? ( bag1 + bag2 - 15) * luggagePenalty : 0;
        }
        else
        {
            penalty = 90;
            penalty += (bag1 + bag2 + bag3)> 15 ? (bag1 + bag2 + bag3 - 15) * luggagePenalty : 0;
        }
        return penalty;
    }
    
    
    
    
    
    
    
    
    
    
}