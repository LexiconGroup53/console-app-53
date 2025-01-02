using System.Text.Json;
using console_app;

// UseServiceMethods();
// UseStringDemo();
// UsePerson();
// UseCompany();
// UseHyphenation();
// UseInstitution();
// UseDictionary();
// UseIterationDemo();
// UseUserInput();
// UseConcertRelated();
// UseExceptionsDemo();
// UseListDemo();
UseLINQDemo(); 

void UseLINQDemo()
{
    /*string mockData = File.ReadAllText("MOCK_DATA.json");
    List<Student> students = JsonSerializer.Deserialize<List<Student>>(mockData);

    // LinqDemo.FilterAge(students);
    List<int> first = LinqDemo.GetStudentId(students);
    List<int> second = LinqDemo.GetAnotherStudentId(students);

    
    List<int> reduced = first
        .Intersect(second)
        .ToList();

    foreach (int item in reduced)
    {
        Console.WriteLine(item);
    }*/
}

void UseListDemo()
{
    ListDemo demo = new ListDemo();
    
    Person toRemove = demo.FindListItem("Dally");
    bool success = demo.RemoveFromList(toRemove);

    Person newPerson = new Person("Petty", "Crime");
    demo.AddItem(newPerson);
    List<Person> persons = demo.GetList();
    foreach (Person person in persons)
    {
        Console.WriteLine("Firstname: " + person.FirstName + " – Lastname: " + person.LastName);
    }
    demo.PersistList();
    List<Person> restoredList = demo.RestoreList();
    foreach (Person person in restoredList)
    {
        Console.WriteLine(person.FirstName + " " + person.LastName + " is back");
    }
}
void UseExceptionsDemo()
{
    try
    {
        Console.WriteLine(ExceptionsDemo.GetNumberWithCatch());
    }
    catch
    {
        Console.WriteLine("In program.cs – too long a number");
    }

    Console.WriteLine("Continue in program.cs");
}

void UseConcertRelated()
{
    ConcertRelated.UseParse();
}
void UseUserInput()
{
    /*
    Console.WriteLine("User input (enter text to start execution again)");
    string textInput = Console.ReadLine();
    Console.WriteLine("You wrote: " + textInput);
        */
    int numberInput = Console.Read();
    Console.WriteLine(numberInput);
    Console.ReadLine();

    ConsoleKeyInfo keyPressed = Console.ReadKey();
    char entry = keyPressed.KeyChar;
    
    Console.WriteLine(keyPressed.Key);
    Console.WriteLine(keyPressed.Modifiers);
}
void UseIterationDemo()
{
    string[] result = IterationDemo.UseWhile();

    foreach (string item in result)
    {
        Console.WriteLine(item);
    }

    int lengthOfString = IterationDemo.UseDoWhile();
    Console.WriteLine(lengthOfString);
}
void UseDictionary()
{
    bool energy = DictionaryDemo.UseDictionary();
    /*
     foreach (var item in energy)
    {
        Console.WriteLine(item);
    }
    */
    Console.WriteLine(energy);
}

void UseInstitution()
{
    Institution newInstitution = new Institution(1, "AF", 3281);
    bool isSuccessful = newInstitution.ChangeSize(89);

    Console.WriteLine(newInstitution.Size);
    Console.WriteLine(isSuccessful);
    // Institution anotherInstitution = new Institution();
    string otherColor = "Yellow";
    
    Color color = Color.Yellow;
    if (color == Color.Yellow)
    {
        Console.WriteLine(color);
    }

    AltColor newAltColor = new AltColor();
    newAltColor.SetToBlue();
    string colorChoice = newAltColor.Color;
    if(colorChoice.Equals("Blue")) Console.WriteLine("Blue");
}
void UseHyphenation()
{
    string[] text = Hyphenation.GetFormattedText();
    foreach (string line in text)
    {
        Console.WriteLine(line);
    }
}

void UseCompany()
{
    Company Geveko = new Company();
    Person ceo = new Person();
    ceo.FirstName = "Ann";
    ceo.LastName = "Olsson";
    Geveko.CEO = ceo;
    Geveko.YearFounded = 1985;
    Console.WriteLine(Geveko.GetPhrase());
}

void UsePerson()
{
    // string fullName = Person.GetFullName("Fredrik", "Persson");
    Person newPerson = new Person();
    System.Type testOfType = newPerson.GetType();
    // newPerson.SetFirstName("Ann");
    newPerson.FirstName = "Ann";
    newPerson.LastName = "Olsson";
    string firstName = newPerson.FirstName;
    string fullName = newPerson.GetFullName();

    // newPerson.SetLastName("Olsson");
    Console.WriteLine(fullName);
}

void UseStringDemo()
{
    StringDemo demo = new StringDemo();
    string[] result = demo.SplitTextToArray();
    string printOutText = "";
    for(int i = 0; i < result.Length; i++)
    {
        printOutText += result[i] + ", ";
    }
    
    // Console.WriteLine(printOutText.TrimEnd(' ', ','));
    
    // String.Length
    // String.IndexOf
    // String.LastIndexOf
    // String.Substring

    string textToWorkWith =
        "Nick sat against the wall of the church where they had dragged him to be clear of machine gun fire in the street. Both legs stuck out awkwardly. He had been hit in the spine. His face was sweaty and dirty. The sun shone on his face. The day was very hot. Rinaldi, big backed, his equipment sprawling, lay face downward against the wall.";
    Console.WriteLine(textToWorkWith.Length);
    
    Console.WriteLine(textToWorkWith[335]);
    char[] textAsChars = textToWorkWith.ToCharArray();
    Console.WriteLine(textAsChars[335]);
    Console.WriteLine(textToWorkWith.IndexOf('w'));
    Console.WriteLine(textToWorkWith.IndexOf("wall"));
    Console.WriteLine(textToWorkWith.LastIndexOf('w'));
    int firstSpace = textToWorkWith.IndexOf(' ');
    Console.WriteLine(firstSpace);
    Console.WriteLine(textToWorkWith.Substring(310));
    Console.WriteLine(textToWorkWith[310]);
    string snippet = textToWorkWith.Substring(0, 4);
    string textToWorkWithTemp = textToWorkWith.Remove(0, 5);
    Console.WriteLine(snippet);
    Console.WriteLine(textToWorkWithTemp);
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
