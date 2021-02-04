using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 }; //gerçek hayatta urun1-urun2 kısmı bir veri kaynağından gelir; excel, API gibi

            //product: type-safe sebebiyle yazılır.çalışacağı veri tipinin string mi integer mi yoksa benim belirlediğim Product gb bir veri tipimi bilmek ister.
            //urun: takma isim, x gb. urunler: foreach'i nerde döndüreceğini söylüyorum.
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------------------------metotlar------------------------------");

            //instance-örnek oluşturma
            //encapsulation: ayrı ayrı yazacağın bilgiyi bir kapsüle alıp yazma işlemi gb düşünülebilir. yani productsdaki class.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
