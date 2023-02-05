using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Net.Http.Headers;

namespace LINQ_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2, 12, -36, 7 };
            var str = "Abilities forfeited situation extremely my to he resembled.Old had conviction discretion understood put principles you";
            var strLits = new List<string>() { "Abilities", "forfeited", "situation", "extremely", "my", "to", "he", "resembled", "Old", "had", "conviction", "discretion", "understood", "put", "principles", "you" };
            string[] substrings = new string[] {"a"};
            //1
            var result = intList.Where(item => item % 2 == 0 & item % 3 == 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //2
            Console.WriteLine("sum");
            int sum = intList.Sum();
            Console.WriteLine(sum);
            //3
            Console.WriteLine("average");
            var average = intList.Average();
            Console.WriteLine(average);
            //4
            Console.WriteLine("max");
            int maximal = intList.Max();
            Console.WriteLine(maximal);
            //5
            Console.WriteLine("mim");
            int minimat = intList.Min();
            Console.WriteLine(minimat);
            //6
            Console.WriteLine(">10 i *10");
            var result2 = intList.Where(item => item > 10).Select(item => item * 10);
            foreach (var item in result2)
            {
                Console.Write(item + " ");

            }
            //7
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

            //8
            Console.WriteLine("count");
            var count = intList.GroupBy(n => n).Select(group => new { Number = group.Key, Frequency = group.Count() }).OrderByDescending(group => group.Frequency);
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Number}: {item.Frequency}");
            }
            //9
            Console.WriteLine("group");
            var group = intList.GroupBy(x => x % 2 == 0).Select(group => new { GroupType = group.Key ? "Even" : "Odd", MaxNumber = group.Max() });
            foreach (var item in group)
            {
                Console.WriteLine(item.GroupType + " " + item.MaxNumber);
            }
            //10
            Console.WriteLine("greater than the average");
            var result6 = intList.Where(item => item > intList.Average());
            foreach (var item in result6)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //11
            Console.WriteLine("Group by length");
            var length =
                from data in strLits
                group data by data.Length into lgh
                select new
                {
                    Length = lgh.Key,
                    Data = lgh
                };
            foreach (var item in length)
            {
                Console.WriteLine($"{item.Length}:");
                foreach (var strData in item.Data)
                {
                    Console.WriteLine(strData);
                }
            }
            //12
            Console.WriteLine("12");
            var result12 = strLits.Where(s => substrings.All(substring => s.Contains(substring))).GroupBy(s => s.Length).SelectMany(g => g.Select(s => s.First().ToString().ToUpper() + s.Substring(1).ToLower())).ToList();
            foreach (string item in result12)
            { 
                Console.WriteLine(item);
            }
                

        }
    }
}