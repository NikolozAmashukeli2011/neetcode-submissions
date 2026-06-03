public class Solution {

public bool IsAnagram(string s, string t) {
    
if(s.Length != t.Length)
return false;

    
Dictionary<char, int> s_map = new Dictionary<char, int>();
Dictionary<char, int> t_map = new Dictionary<char, int>();

foreach(var c in s)
s_map[c] = s_map.GetValueOrDefault(c, 0) + 1;

foreach(var c in t)
t_map[c] = t_map.GetValueOrDefault(c, 0) + 1;



foreach(var kvp in s_map)
{
if(s_map[kvp.Key] != t_map.GetValueOrDefault(kvp.Key, 0))
return false;
}

return true;

}

}
