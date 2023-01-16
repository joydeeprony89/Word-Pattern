// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// https://leetcode.com/problems/word-pattern/

public class Solution
{
  public bool WordPattern(string pattern, string s)
  {
    var pLength = pattern.Length;
    var sArr = s.Split(" ");
    var sLength = sArr.Length;
    if (pLength != sLength) return false;
    var mapChar = new Dictionary<char, string>();
    var mapWord = new Dictionary<string, char>();
    for (int i = 0; i < sLength; i++)
    {
      var key = pattern[i];
      var value = sArr[i];
      if (!mapChar.ContainsKey(key))
      {
        mapChar.Add(key, value);
      }

      if (!mapWord.ContainsKey(value))
      {
        mapWord.Add(value, key);
      }

      if ((mapChar[key] != value) || (mapWord[value] != key)) return false;
    }

    return true;
  }
}