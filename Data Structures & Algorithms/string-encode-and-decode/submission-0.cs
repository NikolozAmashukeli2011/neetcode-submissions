public class Solution {

public string Encode(IList<string> strs) {
string result = "";

foreach(string s in strs) 
{
result += $"{s.Length}#{s}";
}

return result;
}

public List<string> Decode(string s) {

List<string> decoderList = new();
int indexOfSeparator = 0;
int length = 0;
string lengthString = "";

for(int i = 0; i < s.Length; i = indexOfSeparator + 1 + length)
{

indexOfSeparator = s.IndexOf("#", i);
lengthString = s.Substring(i, indexOfSeparator - i);
length = int.Parse(lengthString);
decoderList.Add(s.Substring(indexOfSeparator + 1, length));

}

return decoderList;
}


}
