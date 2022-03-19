using System;

namespace KampIntro
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //type safety
            string kategoriEtiketi = "kategori";
            Console.WriteLine("kategori");
            Console.WriteLine(kategoriEtiketi);
            int öğrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("kullanıcı ayarlar butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            




            





        }
    }
}
