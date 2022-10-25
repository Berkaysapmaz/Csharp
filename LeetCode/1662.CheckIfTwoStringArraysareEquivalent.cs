public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        /*Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
        A string is represented by an array if the array elements concatenated in order forms the string.*/
        string string1 = "";
        string string2 = "";
        
        foreach(string item in word1)
        {
            string1 += item;
        }
        foreach(string item in word2)
        {
            string2 += item;
        }
        return string.Equals(string1,string2);
    }
}

	
    /*return "".join(word1) == "".join(word2)     Or jut one line */