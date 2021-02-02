using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductBrand = "Apple";
            product1.ProductCategory = "Cep TelefonuAksesuarları";
            product1.ProductName = "Apple Watch Seri 3 GPS 38 mm ";
            product1.ProductPrice = 1745;

            Product product2 = new Product();
            product2.ProductBrand = "Vestel";
            product2.ProductCategory = "Ses Görüntü Sistemleri";
            product2.ProductName = "Vestel 65U9500 65'' 164 Ekran";
            product2.ProductPrice = 5360;

            Product product3 = new Product();
            product3.ProductBrand = "Xiaomi";
            product3.ProductCategory = "Süpürgeler";
            product3.ProductName = "Xiaomi Mi Vacuum Mop 1C 2 in 1";
            product3.ProductPrice = 2299;

            Product product4 = new Product();
            product4.ProductBrand = "Activex";
            product4.ProductCategory = "Duş Banyo Ürünleri";
            product4.ProductName = "Activex Antibakteriyel Sıvı Sabun";
            product4.ProductPrice = 35;

            Product product5 = new Product();
            product5.ProductBrand = "Lipton";
            product5.ProductCategory = "Çaylar";
            product5.ProductName = "Lipton Doğu Karadeniz Dökme Çay";
            product5.ProductPrice = 134;

            Product[] products = new Product[] { product1, product2, product3, product4, product5 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductBrand + " -> " + products[i].ProductCategory+ " -> "+ products[i].ProductName+" -> "+products[i].ProductPrice+"\n");
            }
            Console.WriteLine("FOR BİTTİİİİİİİİİİİİİİİİİİİİİİİİİİİİİ \n");

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductBrand + " -> " + product.ProductCategory + " -> " + product.ProductName + " -> " + product.ProductPrice + "\n");
            }

            Console.WriteLine("FOREACH BİTTİİİİİİİİİİİİİİİİİİİİİİİİİİİ \n");

            int a = 0;
            while (a<products.Length)
            {
                Console.WriteLine(products[a].ProductBrand + " -> " + products[a].ProductCategory + " -> " + products[a].ProductName + " -> " + products[a].ProductPrice + "\n");
                a++;
            }
        }

    }

    class Product
    {
        public  string ProductBrand { get; set; }
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }


    }
}
