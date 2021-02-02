using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        //Product burada parametre
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Name);

        }

        public void Add2(string productName, string explanation, double price, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productName);
        }
    }
}
