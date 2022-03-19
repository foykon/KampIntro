using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 19;
            string adı = "furkan";

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "java";
            kurs1.KursunEgitmeni = "kerem";
            kurs1.IzlenmeOranı = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "c#";
            kurs2.KursunEgitmeni = "engin demiroğ";
            kurs2.IzlenmeOranı = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "python";
            kurs3.KursunEgitmeni = "berkay";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "c++";
            kurs4.KursunEgitmeni = "murat";
            kurs4.IzlenmeOranı = 100;

            Console.WriteLine(kurs1.KursAdı+" : "+kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("programlama dili : "+kurs.KursAdı);
                Console.WriteLine("eğitmen ismi : "+kurs.KursunEgitmeni);
                Console.WriteLine("izleyen : "+kurs.IzlenmeOranı);
            }





        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }

    } 


}
