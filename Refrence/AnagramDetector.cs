using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Refrence
{
    public class AnagramDetector
    {
        public static bool isAnagram(string string1, string string2)
        {
            Dictionary<char, int> stringOneMap = MapString(string1), stringTwoMap = MapString(string2);
            if (stringOneMap.Count != stringTwoMap.Count)
                return false;
            foreach (KeyValuePair<char,int> keyValuePair in stringOneMap)
            {
                if (stringTwoMap[keyValuePair.Key] != keyValuePair.Value)
                    return false;
            }
            return true;
        }

        private static Dictionary<char, int> MapString(string s)
        {
            ConcurrentDictionary<char,int> map = new ConcurrentDictionary<char, int>();
            foreach (char c in s)
            {
                map.AddOrUpdate(c, 1, ((c1, i) => i + 1));
            }

            return new Dictionary<char, int>(map);
        }
    }
}