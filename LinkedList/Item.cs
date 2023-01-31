using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Item<T>    
    {
        private T data = default(T);
       
        public T Data 
        {
            get { return data;  }
            set
            {
                if (value != null)
                {
                    data = value;
                }
            }
        }
        public Item<T> Next { get; set; }
        public Item(T data) 
        { 
         Data= data;
        }
    }
}
