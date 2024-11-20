namespace console_app;

public class StringDemo
{
    public static void ExplainStaticVersusInstance()
    {
        // Car.GetCarIcon();
        // Car myNewCar = new Car();
        // myNewCar.Brand = "Ford";
        // myNewCar.GetBrand();

        // string demo = String.Join();
        // string demo2 = "Demo of instance".ToLower();
        // demo2.EndsWith('r');
    }

    public string[] SplitTextToArray()
    {
        string textToTransform =
            "The following example shows a few representative features of Type. The   C# typeof operator (GetType operator in Visual Basic) is used to get a Type object representing String. From this Type object, the GetMethod method is used to get a MethodInfo representing the String.Substring overload that takes a starting location and a length.";
        string[] textArray = new string[4] {"Ground", "Err", "Mighty", "Annie"};
        textArray[0] = "Follow";
        textArray[0] = "Free";
        Char[] charsToUse = new Char[] { ' ', '.', ',', '(', ')' };
        string[] textTransformed = textToTransform.Split(charsToUse, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(textTransformed);
        return textTransformed;
    }
}