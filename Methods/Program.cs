using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyat = 15;
            string aciklama = "amasya elması";

            Product product1 = new Product();
            product1.Id = 01;
            product1.Adi = "elma";
            product1.Fiyati = 15;
            product1.Aciklama = "amasya elması";

            Product product2 = new Product();
            product2.Id = 02;
            product2.Adi = "karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("*****************************************");

            SepetManager sepetManager = new SepetManager();

            foreach (Product product in products)
            {
                sepetManager.Ekle(product);
            }
            
                
        }
    }
}
