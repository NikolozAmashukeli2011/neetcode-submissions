public class Solution {

public bool IsAnagram(string s, string t) {
    
if(s.Length != t.Length)
return false;

Dictionary<char, int> map = new Dictionary<char, int>();


foreach(var c in s)
map[c] = map.GetValueOrDefault(c, 0) + 1;

foreach(var c in t)
map[c] = map.GetValueOrDefault(c, 0) - 1;


foreach(var kvp in map)
{
if(map[kvp.Key] != 0)
return false;
}

return true;

}
}
