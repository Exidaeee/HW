using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2._5
{
    class AgeException: Exception
    {
        public AgeException(string message)
        : base(message)
        { }
    }
    class BasketException : Exception
    {
        public BasketException(string message)
        : base(message)
        { }
    }
    class ProductException : Exception 
    {
        public ProductException(string message)
         : base(message)
        { }
    }
}
