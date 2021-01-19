using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Odev odev1 = new Odev();
            odev1.DersAdi = "Matematik";
            odev1.OdevSayisi = 3;
            odev1.TeslimTarihi = "21.01.2021";

            Odev odev2 = new Odev();
            odev2.DersAdi = "Türkçe";
            odev2.OdevSayisi = 5;
            odev2.TeslimTarihi = "21.01.2021";

            Odev odev3 = new Odev();
            odev3.DersAdi = "Tarih";
            odev3.OdevSayisi = 1;
            odev3.TeslimTarihi = "24.01.2021";

            OdevManager odevManager = new OdevManager();

            odevManager.OdevEkle(odev1);
            Console.WriteLine(" ");
            odevManager.OdevEkle(odev2);
            Console.WriteLine(" ");
            odevManager.OdevEkle(odev3);
            Console.WriteLine(" ");

            Console.WriteLine("ÖDEV LİSTESİ");
            Console.WriteLine(" ");
            Odev[] odevler = new Odev[] { odev1, odev2, odev3 };

            foreach (var odev in odevler)
            {
                odevManager.OdevListele(odev);
            }

            
        }
    }
}
