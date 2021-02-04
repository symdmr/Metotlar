using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //burada yapılan bir değişikliği tüm sayfalarda görmek adına metot olarak kullanıyoruz.
        public void Ekle(Product urun) //product: veri tipi, str veya int gb. urun: neyi yazdıracağım. o kısma imza denir.
        {
            Console.WriteLine("sepete eklendi : "+urun.Adi);
        }
    }
}
