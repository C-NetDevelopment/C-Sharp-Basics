namespace DictionaryLab
{
    internal class ProgramBase
    {

        public string Value(Dictionary<int, string> dict)
        {
            foreach (KeyValuePair<int, string> item in dict)
            {
                return $"{dict.Keys} {dict.Values}";
            }
        }
    }
}