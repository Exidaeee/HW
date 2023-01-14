using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Node<T> //: IComparable<T>
                  where T : IComparable<T> 
    {
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public T Data { get; private set; }
        public Node<T>? Left { get;private set; }
        public Node<T>? Right { get;private set; }

        public void Add(T data)
        { 
          var node = new Node<T>(data);
            if (node.CompareTo(Data) ==-1)
            {
                if (Left == null)
                {
                  Left= node;
                  
                }
                else Left.Add(data);
            }
            else
            {
                if (Right ==null)
                {
                    Right= node;
                }
                else Right.Add(data);
            }
        }


        private int CompareTo(T data)
        {
           return Data.CompareTo(data); 
        }

       
    }
}
