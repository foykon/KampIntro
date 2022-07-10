using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();           
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,new List<ILoggerService>() {new DatabaseLoggerService(),new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnbilgilendirmesi(krediler);



        }
    }
}
