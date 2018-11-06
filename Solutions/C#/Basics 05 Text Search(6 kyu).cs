namespace smile67Kata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Kata 
    {
        public List<int> searchText(string text, string pattern, bool behind) 
        {
            return (text == "" || pattern == "")
              ? new List<int>()
              : Regex.Matches(text, behind ? pattern : $"(?={pattern})")
                .OfType<Match>()
                .Select(x => x.Index)
                .ToList();
        }
    }
}