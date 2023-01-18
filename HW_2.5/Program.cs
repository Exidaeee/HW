namespace HW_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger person = new Logger();   
           // person.name = Console.ReadLine();
            Online_shop onlineShop = new Online_shop();
            Console.WriteLine("Список товарiв:");
            onlineShop.Product();
            string produkts = Console.ReadLine();
            onlineShop.AddToBasket(produkts);
        }
    }
}