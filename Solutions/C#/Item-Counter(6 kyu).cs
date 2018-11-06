using System;
using System.Linq;

namespace ItemCounterKata
{
    public class ItemCounter<T>
    {
        readonly T[] items;

        public int DistinctItems
        {
            get
            {
                return items.Distinct().Count();
            }
        }

        public int GetCount(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            
            if (!items.Any(x => x.Equals(item)))
            {
                throw new InvalidOperationException();
            }
            
            return items.Count(x => x.Equals(item));
        }

        public bool HasItem(T item)
        {
            return items.Contains(item);
        }

        public ItemCounter(T[] items)
        {
            if (items == null)
            {
              throw new ArgumentNullException();
            }
        
            this.items = items;
        }
    }
}