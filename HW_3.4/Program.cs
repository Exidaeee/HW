using System;

namespace HW_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Sofia", "Luzan", "luzansofia@gmail.com", DateTime.Parse("1995 08 12"), 231421);
            Person person2 = new Person("Viktor", "Artemov", "artemov@ukr.net", DateTime.Parse("2005 12 18"), 321221);
            Person person3 = new Person("Maria", "Fisher", "fisher1292@gmail.com", DateTime.Parse("1980 06 02"), 16657);
            Person person4 = new Person("Olesia", "Clark", "olesiaclark21@gmail.com", DateTime.Parse("1994 07 13"), 58437);
            Person person5 = new Person("Patryk", "Podlesniy", "patryk22321@gmail.com", DateTime.Parse("2001 08 20"), 505707);
            Person person6 = new Person("Anjey", "Lybovski", "p.lybovski@gmail.com", DateTime.Parse("2003 09 12"), 454539);
            Person person7 = new Person("Yulia", "Stuguk", "stuguk.yulia@ukr.net", DateTime.Parse("1993 08 12"), 515684);
            Person person8 = new Person("Milana", "Luzan", "milana.luzan@ukr.net", DateTime.Parse("2006 06 12"), 478358);
            Person person9 = new Person("Luckas", "Clark", "clakrluck@gmail.com", DateTime.Parse("1995 11 20"), 486259);
            Person person10 = new Person("Andrij", "Luzan", "andrijluzan@ukr.net", DateTime.Parse("1996 04 03"), 852654);
            List<Person> list = new List<Person>() { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            var alt = from person in list
            where person.Birhtday < DateTime.Now.AddDays(-6570)
                      select person;

            foreach (var person in alt)
            {
                Console.WriteLine($"{person.First_Name}  {person.Last_Name}   {person.Birhtday} ");
            }
            Console.WriteLine();

            var groupedEmail = list.GroupBy(u => u.Email.Split('@')[1]).Select(g => new { Domain = g.Key, Count = g.Count() }).OrderByDescending(g => g.Count).First();
            Console.WriteLine($"Domain: {groupedEmail.Domain}, users count: {groupedEmail.Count}");
            Console.WriteLine();
           
            var id = list.ToDictionary(person => person.Id);
            foreach (var person in id)
            {
                Console.WriteLine($"Key {person.Key}: {person.Value.First_Name} {person.Value.Last_Name}  ");
            }
            Console.WriteLine();

            var GroupLastName =
                from person in list
                orderby person.Birhtday
                group person by person.Last_Name;
            foreach (var item in GroupLastName)
            {
                Console.WriteLine(item.Key);
                foreach (var person in item)
                {
                    Console.WriteLine(person.First_Name + " " + person.Last_Name + " " + person.Birhtday);
                }
                Console.WriteLine();
            }
        }
    }
}
