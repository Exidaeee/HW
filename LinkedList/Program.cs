
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Delete(3);
            list.Add(4);
            list.Add(7);
            list.Add(4);
            list.Add(5);
            list.Add(7);
            list.Add(4);
            list.Add(5);
            list.Add(2, 8);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            var result = list.WhereEquals(4);
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();




        }
    }
}