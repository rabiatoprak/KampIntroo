using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //class bu üçünü bir arada tutan yapıdır. 
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya elması";

            //class ın örneği
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1, product2 };

            //type - safe -- tip güvenliği
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------------------------");

            }

            Console.WriteLine("---------------Metotlar--------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}

//Do not repeat yourself - DRY - Clean Code - Best Practice