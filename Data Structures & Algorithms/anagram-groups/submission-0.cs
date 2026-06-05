public class Solution {
public List<List<string>> GroupAnagrams(string[] strs) {

Dictionary<string, List<string>> map = new();

foreach(var s in strs) 
{

char[] sorted = s.ToCharArray();
Array.Sort(sorted);
string key = new string(sorted);

if(!map.ContainsKey(key))
map[key] = new List<string>();

map[key].Add(s);

}

return new List<List<string>>(map.Values);

}

}
