using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>: IEnumerable
    {  
        public LinkedList() 
        {
            Head = null;
            Tail = null;
            Count = 0; 
        } 
        public Item<T> Head { get; set; }
        public Item<T> Tail { get;private set; }
        public int Count { get; private set; }
        public LinkedList(T data) 
        {
            var item = new Item<T>(data); 
            Head = item;
            Tail = item;
            Count = 1;
        }
        public void Add(T data) 
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                Head = item;
                Tail = item;
                Count = 1;
            }

        }
        public void Add( T target,T data)
        {
            
            if (Head != null)
            {
                var item = new Item<T>(data);
                var current = Head;
                while (current != null)
                {

                    if (current.Data.Equals(target))
                    {
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else Add(data);
        }
        public void Delete(T data) 
        {
            if (Head!=null)
            {
                if (Head.Data.Equals(data)) 
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while (current!= null)
                {
                    if (current.Data.Equals(data)) 
                    {
                        previous.Next = current.Next;
                        Count--;
                        
                    }
                    previous= current;
                    current = current.Next;
                }
            }
           
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null) 
            {
              yield return current.Data;
                current = current.Next;
            }
        }

       
    }

    public static class Extention
    {
        public static IEnumerable WhereEquals<T>(this IEnumerable target, T data)
        {
            foreach (var item in target)
            {
                if (data.Equals(item))
                {
                    yield return item;
                }
               
            }
           
        }
    }
}
