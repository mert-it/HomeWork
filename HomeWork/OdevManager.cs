using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class OdevManager
    {
        public void OdevEkle(Odev odev)
        {
            Console.WriteLine("EKLENEN ÖDEV");
            Console.WriteLine("Eklenen Ödev : " + odev.DersAdi + " (Eklendi)");
            Console.WriteLine("------------------");
        }
        public void OdevListele (Odev odev)
        {
            Console.WriteLine("Ders Adı : " + odev.DersAdi);
            Console.WriteLine("Ödev Sayısı :" + odev.OdevSayisi);
            Console.WriteLine("Teslim Tarihi : " + odev.TeslimTarihi);
            Console.WriteLine(" ");
        }
    }
}
