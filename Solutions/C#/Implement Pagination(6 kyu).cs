using System;
using System.Collections.Generic;
using System.Linq;

public class Pagination<T>
{
  readonly IEnumerable<T> source;
  
  public IEnumerable<T> Items
  {
    get { return source.Skip((CurrentPage - 1) * ItemsPerPage).Take(ItemsPerPage); }
  }
  
  int currentPage = 1;
  public int CurrentPage
  {
    get { return currentPage; }
    set
    {
      if (value < 1)
      {
        value = 1;
      }
      
      currentPage = value;
    }
  }
  
  int itemsPerPage = 10;
  public int ItemsPerPage
  {
    get { return itemsPerPage; }
    set
    {
      if (value < 1)
      {
        value = 10;
      }
      
      itemsPerPage = value;
    }
  }
  
  public int Total
  {
    get { return source.Count(); }
  }
  
  public int TotalPages
  {
    get { return (int)Math.Ceiling((double)Total / (double)ItemsPerPage); }
  }

  public Pagination(IEnumerable<T> source)
  {
    this.source = source;
  }
}