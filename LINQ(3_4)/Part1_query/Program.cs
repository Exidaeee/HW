using System.Linq;
using System.Reflection;

namespace Part1_query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 , 12, -36, 7 };
            var str = "Abilities forfeited situation extremely my to he resembled.Old had conviction discretion understood put principles you";

            var result = intList.Where(item => item % 2 == 0 & item % 3 == 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("sum");
            int sum = intList.Sum();
            Console.WriteLine(sum);
            Console.WriteLine("average");
            var average = intList.Average();
            Console.WriteLine(average);
            Console.WriteLine("max");
            int maximal = intList.Max();
            Console.WriteLine(maximal);
            Console.WriteLine("mim");
            int minimat = intList.Min();
            Console.WriteLine(minimat);
            Console.WriteLine(">10 i *10");
            var result2 = intList.Where(item => item > 10).Select(item => item * 10);
            foreach (var item in result2)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine("unique characters");
            var symbol =
            from sim in str.ToCharArray()
            where (sim != ' ')
            group sim by sim into grup 
            select grup.First();

            foreach (var ch in symbol)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("group");
            var group =
                from item in intList
                group item by item % 2 == 0;
            foreach (var item in group)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.)
                }
            }
            Console.WriteLine("count");
            //var result5 = intList.Where(item => )
            Console.WriteLine("greater than the average");
            var result6 = intList.Where(item => item > intList.Average());
            foreach (var item in result6)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}