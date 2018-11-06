using System.Collections.Generic;
using System.Linq;

namespace Kata
{
  public class TitleSorter
  {
    bool startsWithArticle(string title)
    {
      title = title.ToLower().Trim();
      var articles = new string[] { "the", "an", "a" };
      
      foreach (var article in articles)
      {
        if (title == article)
        {
          return false;
        }
        
        if (title.StartsWith(article + " "))
        {
          return true;
        }
      }
      
      return false;
    }
  
    public List<string> Sort(List<string> unsortedTitles)
    {
      return unsortedTitles?
        .OrderBy(x => startsWithArticle(x) 
          ? $"{x.Substring(x.IndexOf(" ") + 1)}, {x.Substring(0, x.IndexOf(" "))}" : x)
        .ToList();
    }
  }
}