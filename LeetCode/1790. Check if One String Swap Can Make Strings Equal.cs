public bool AreAlmostEqual(string s1, string s2) {
	
  /*You are given two strings s1 and s2 of equal length. A string swap is an operation where you choose two indices in a string (not necessarily different) and swap the characters at these indices.

Return true if it is possible to make both strings equal by performing at most one string swap on exactly one of the strings. Otherwise, return false.*/
  
        var c = 0;
        var j = 0;
        for (var i = 0; i < s1.Length; i++) {
          if (s1[i] == s2[i]) continue;
          if (++c > 2 || c == 2 && (s1[i] != s2[j] || s1[j] != s2[i])) return false;
          j = i;
	}
      return c != 1;
}