using console_app;

// UseServiceMethods();
UseStringDemo();

void UseStringDemo()
{
    StringDemo demo = new StringDemo();
    string[] result = demo.SplitTextToArray();
    string printOutText = "";
    for(int i = 0; i < result.Length; i++)
    {
        printOutText += result[i] + ", ";
    }
    
    Console.WriteLine(printOutText.TrimEnd(' ', ','));
    
}

void UseServiceMethods()
{
    bool lower = ServiceMethods.CalculateAverage(23, 26, 67) > ServiceMethods.CalculateAverageDifference(34, 12, 19);

    ServiceMethods method = new ServiceMethods();
    double result = method.DivideNumbers(1, 2);

    Console.WriteLine(ServiceMethods.GetFullName(ServiceMethods.ReturnMary(), "Leith"));

    string firstParticipant = ServiceMethods.GetFullName("Mary", "Leith");
    string secondParticipant = ServiceMethods.GetFullName("Tim", 'K', "Olson");
    Console.WriteLine(firstParticipant);

    Console.WriteLine(ServiceMethods.CalculateAverageDifference(9, 43, 89));
}
