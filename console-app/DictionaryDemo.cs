namespace console_app;

public class DictionaryDemo
{
    private static Dictionary<string, int> energyContent = new Dictionary<string, int>();
    
    // Träd --- Tree
    
    // "34, 56, 78" 39111153
    // URL "<!Doctyp....
    
    // Dictionary<TKey, TValue>

    public static bool UseDictionary()
    {
        energyContent.Add("Apple", 120);
        // energyContent.Add("Apple", 56);
        energyContent.Add("Banana", 145);
        int energy = energyContent["Apple"];
        // energyContent.Remove("Banana");
        int sizeOf = energyContent.Count;
        var keys = energyContent.Keys;

        bool isThere = energyContent.ContainsKey("Banana");
        bool isAlsoThere = energyContent.ContainsValue(145);
        
        return isAlsoThere;

    }
}