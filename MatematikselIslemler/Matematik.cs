using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselIslemler
{
    public class Matematik
    {
        // topla
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc=sayi1 + sayi2;
            return sonuc;
        }

        // cikart
        public decimal cikartmaİslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        // bolme
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        // carpma
        public decimal carpmaIslemi(decimal sayi1,decimal sayi2)
        {
            decimal sonuc=sayi1 * sayi2;
            return sonuc;
        }

        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("****Menü****");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkartma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Lütfen bir değer seçiniz : ");
        }

        public void sonucekranayaz(decimal kullanicisayi1, decimal kullanicisayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}",kullanicisayi1,operators,kullanicisayi2,sonuc);
        }

    }
}
