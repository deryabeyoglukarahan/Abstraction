using System;

namespace AbstractionExample
{
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public abstract void Gorev();

        public void BilgiYazdir()
        {
            Console.WriteLine($"{Ad} {Soyad} - {Departman}");
        }
    }

    public class YazilimGelistirici : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
        }
    }

    public class ProjeYoneticisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }

    public class SatisTemsilcisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("İş Analisti olarak çalışıyorum.");
        }
    }
}
