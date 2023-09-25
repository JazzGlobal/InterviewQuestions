public class ExceptionHandling {
    string[] keys = new string[] { "key1", "key2", "key3", "key1" };
    string[] values = new string[] { "value1", "value2", "value3", "value4" };
    
    public Dictionary<string, string> BuildDictionary() {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        for (int i = 0; i < keys.length; i++) 
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
    }

    public Dictionary<string, string> BuildDictionary2() {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();

        for (int i = 0; i < keys.length; i++) 
        {
            if (dictionary.ContainsKey(keys[i]))
                continue;
            dictionary.add(keys[i]);   
        }
    }
}