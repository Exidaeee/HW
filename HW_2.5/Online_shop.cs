using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2._5
{
    class Online_shop
    {
        private string[] products =  new[]{ "Сир", "Молоко", "М'ясо", "Алкоголь", "Риба", "Картопля", "Морква", "Яблука", "Виноград", "Печиво" };
        private List<string> basket = new (10);
        int number = 0; 
        public void Product()
        {
            foreach (string item in products)
            {
                Console.WriteLine(item);
            }
        }
        public void AddToBasket(string produkt) // додати ексепшин якщо товар відсутній
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (produkt == products[i])
                {
                    basket.Add(products[i]);
                    Console.WriteLine(products[i]+ " додано до кошика");
                }
                
                
            }
        }

    }
}
