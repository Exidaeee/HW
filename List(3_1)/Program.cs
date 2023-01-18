namespace List_3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(5);
            list.Add(7);
            list.Add(3);
            list.Add(4);
            list.Add(6);
            bool x = list.Remove(3);
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(1);
            list[0] = 2;
            list.Sort();
            int[] myArray = new[] { 1, 2, 3, 5 };
            list.AddRange(myArray);           
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}