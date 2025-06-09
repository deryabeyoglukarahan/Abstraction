using System;

namespace AbstractionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjeYoneticisi employee1 = new ProjeYoneticisi
            {
                Ad = "Lütfü",
                Soyad = "Karahan",
                Departman = "Yönetim"
            };

            employee1.BilgiYazdir();
            employee1.Gorev();

            Console.WriteLine();

            YazilimGelistirici employee2 = new YazilimGelistirici
            {
                Ad = "Derya",
                Soyad = "Karahan",
                Departman = "Yazılım"
            };

            employee2.BilgiYazdir();
            employee2.Gorev();

            Console.WriteLine();

            SatisTemsilcisi employee3 = new SatisTemsilcisi
            {
                Ad = "Selin",
                Soyad = "Erkılıç",
                Departman = "Analist"
            };

            employee3.BilgiYazdir();
            employee3.Gorev();

            Console.ReadLine();
        }
    }
}
