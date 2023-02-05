namespace HW_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var postOffice = new Post();
            var mail = new User(postOffice);
            postOffice.ReceiveLetter("лист");
            List<int> list= new List<int>() { 1, 2, 3, 4, 5, 6, 5, 1};
            var x = list.FirstOrDefault2(i => i == 5);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            var y = list.SkipWhile(i => i < 5);
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var z = list.SkipWhile2(i => i < 3);
            foreach (var item in z)
            {
                Console.WriteLine(item);
            }
        }

    }
}