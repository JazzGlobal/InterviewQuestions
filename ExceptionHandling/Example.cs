public class ExceptionHandling
{
    static string[] keys = new string[] { "key1", "key2", "key3", "key1" };
    static string[] values = new string[] { "value1", "value2", "value3", "value4" };

    public static Dictionary<string, string> BuildDictionary()
    {
        Dictionary<string, string> dictionary = new();
        for (int i = 0; i < keys.Length; i++)
        {
            try
            {
                dictionary.Add(keys[i], values[i]);
            }
            catch (ArgumentException)
            {
                // Duplicate key.
            }
        }
        return dictionary;
    }

    public static Dictionary<string, string> BuildDictionary2()
    {
        Dictionary<string, string> dictionary = new();
        for (int i = 0; i < keys.Length; i++)
        {
            if (dictionary.ContainsKey(keys[i]))
                continue;
            dictionary.Add(keys[i], values[i]);
        }
        return dictionary;
    }
}
