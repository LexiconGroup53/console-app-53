using System.Text.Json;

namespace console_app;

public class WebHelp
{
    public static string DoWithNumber(int number)
    {
        int[] numbers = new int[number];
        for (int i = 0; i < number; i++)
        {
            numbers[i] = (i + 4) * 2;
        }
        return JsonSerializer.Serialize(numbers);
    }

    public static int[] DoWithJson(int number)
    {
        string value = DoWithNumber(number);
        return JsonSerializer.Deserialize<int[]>(value);
    }
}