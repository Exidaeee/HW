namespace HW_2._5
{
    class Online_shop
    {
        private readonly ILogger _logger;
        public Online_shop(ILogger logger)
        {
            _logger = logger;
        }

        private string[] products = new[] { "Сир", "Молоко", "М'ясо", "Алкоголь", "Риба", "Картопля", "Морква", "Яблука", "Виноград", "Печиво" };
        private List<string> basket = new();

        public void Product()
        {
            Console.WriteLine("Список товарiв:");
            foreach (string item in products)
            {
                Console.WriteLine(item);
            }
        }

        public void AddToBasket(string produсt)
        {
            if (produсt != null)
            {
                string add = "Товар додано до кошика";
                try
                {
                    switch (produсt)
                    {
                        case "Сир":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "Молоко":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "М'ясо":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "Алкоголь":
                            if (Client.Age >= 18)
                            {
                                basket.Add(produсt);
                                _logger.LogMessage(add);
                            }
                            else throw new AgeException("Товар для повнолiтнiх");
                            break;
                        case "Риба":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "Картопля":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "Морква":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "Яблука":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "Виноград":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        case "Печиво":
                            basket.Add(produсt);
                            _logger.LogMessage(add);
                            break;
                        default:
                            throw new ProductException("Товар вiдсутнiй");
                    }
                }
                catch (AgeException ex)
                {
                    _logger.LogError(ex.Message);
                }
                catch (ProductException ex)
                {
                    _logger.LogError(ex.Message);
                }
            }
        }

        public void Ordering()
        {
            try
            {
                if (basket.Count != 0)
                {
                    string order = "Ваше замовлення сформовано";
                    var list = new List<string>();
                    foreach (var item in basket)
                    {
                        list.Add(item);
                    }
                    basket.Clear();
                    _logger.LogMessage(order);
                }
                else
                {
                    throw new BasketException("Кошик порожнiй");
                }
            }
            catch (BasketException ex)
            {
                _logger.LogError(ex.Message);

            }
        }
    }
}
