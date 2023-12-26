using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Set
{
    public class Setmy<T>
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }
        public void Remove(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            if (!_items.Contains(item))
            {
                throw new KeyNotFoundException($"Элемент {item} не найден в множестве");
            }
            _items.Remove(item);
        }

        public T Take(int n)
        {
            if (n >= 0 && n < Count)
                return _items[n];
            else
                throw new KeyNotFoundException("Индекс за границами множества");
        }
        

    }
}
