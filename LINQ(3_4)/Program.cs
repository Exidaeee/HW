namespace LINQ_3_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new() { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2, 12 };

            var list1 = list.Where(item => item % 3 == 0 & item % 2 == 0);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}