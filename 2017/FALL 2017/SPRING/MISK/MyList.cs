using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class Item<T>
    {
        public T Value { get; set; }
        public Item<T> Next { get; set; }
    }
    class List<T>: IEnumerable<T>
    {
        public Item<T> head { get; private set; }
        Item<T> tail;
        public void Add(T value)
        {
            if (head == null)
                tail = head = new Item<T> { Value = value, Next = null };
            else
            {
                var item = new Item<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public T PullOut(int index)
        {
            if (head == null) throw new InvalidOperationException();
            var element = head;
            for (int i = 0; i < index; i++)
                if (element.Next != null)
                    element = element.Next;
            return element.Value;
        }

        public T IndexOfElement(Item<T> searchElement)
        {
            if (head == null) throw new InvalidOperationException();
            var element = head;
            int i = 1;
            while (element != searchElement)
                if (element.Next != null) i++;
            if (i == this.Count() && searchElement != tail)
                Console.WriteLine("Collection does not contain such an item");  
            return searchElement.Value;
        }
        public int Count()//не до конца немного
        {
            var element = head;
            int count = 0;
            while (element != null)
                count++;
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Show()
        {
            foreach (T element in  )// не до конца немного
        }
    }
}
