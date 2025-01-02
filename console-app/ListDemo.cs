namespace console_app;

public class ListDemo : IListDemo
{
    public List<Person> persons { get; set; } = new List<Person>();

    public ListDemo()
    {
        for (int i = 0; i < 12; i++)
        {
            Person newPerson = new Person();
            newPerson.FirstName = (char) (65 + i) + "ally";
            newPerson.LastName = (char) (65 + i) + "olly";
            persons.Add(newPerson);
        }
    }
    
    public List<Person> GetListy()
    {
        return persons;
    }

    public List<Person> GetList()
    {
        return persons;
    }
    
    public bool RemoveFromList(Person person)
    {
        return persons.Remove(person);
    }

    public Person FindListItem(string firstName)
    {
        return persons.Find(item => item.FirstName.Equals(firstName));
    }

    public Person AddItem(Person person)
    {
        persons.Add(person);
        return person;
    }

    public void PersistList()
    {
        using (StreamWriter writer = new StreamWriter("PersistedList.txt"))
        {
            foreach (Person person in persons)
            {
                writer.WriteLine(person.FirstName);
                writer.WriteLine(person.LastName);
            }
        }
    }

    public List<Person> RestoreList()
    {
        List<Person> restoredList = new List<Person>();
        
        using (StreamReader reader = new StreamReader("PersistedList.txt"))
        {
            while (reader.Peek() > -1)
            {
                Person restoredPerson = new Person();
                restoredPerson.FirstName = reader.ReadLine();
                restoredPerson.LastName = reader.ReadLine();
                restoredList.Add(restoredPerson);
            }
        }

        return restoredList;
    }

    
}