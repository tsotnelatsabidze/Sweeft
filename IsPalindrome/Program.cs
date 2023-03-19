
     bool sPalindrome(string text)
    {


        string actual = System.Text.RegularExpressions.Regex
                                .Replace(text, @"[^A-Za-z0-9]", "")
                                .ToLower();
        string rev = new string(actual.Reverse().ToArray());
        return actual == rev;
    }


