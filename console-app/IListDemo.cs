namespace console_app;

public interface IListDemo
{
    List<Person> GetList();
    Person FindListItem(string firstName);
    bool RemoveFromList(Person person);
    Person AddItem(Person person);
    void PersistList();
    List<Person> RestoreList();
}