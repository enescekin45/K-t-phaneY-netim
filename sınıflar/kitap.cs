using System;
using System.Collections.Generic;


namespace Kutuphane
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string ISBN { get; set; }
        public int YayinYili { get; set; }

        public Kitap(string kitapAdi, string yazarAdi, string isbn, int yayinYili)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            ISBN = isbn;
            YayinYili = yayinYili;
        }

        public override string ToString()
        {
            return $"Kitap Adı: {KitapAdi}, Yazar: {YazarAdi}, ISBN: {ISBN}, Yayın Yılı: {YayinYili}";
        }
    }

    public class Kutuphane
    {
        private List<Kitap> kitaplar = new List<Kitap>();

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
            Console.WriteLine("Kitap başarıyla eklendi!");
        }

        public void KitaplariListele()
        {
            if (kitaplar.Count == 0)
            {
                Console.WriteLine("Kütüphanede hiç kitap yok.");
                return;
            }

            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap.ToString());
            }
        }

        public void KitapAra(string kitapAdi)
        {
            var bulunanKitaplar = kitaplar.FindAll(k => k.KitapAdi.ToLower().Contains(kitapAdi.ToLower()));

            if (bulunanKitaplar.Count == 0)
            {
                Console.WriteLine("Aranan kitap bulunamadı.");
                return;
            }

            foreach (var kitap in bulunanKitaplar)
            {
                Console.WriteLine(kitap.ToString());
            }
        }

        public void KitapSil(string isbn)
        {
            var kitap = kitaplar.Find(k => k.ISBN == isbn);

            if (kitap == null)
            {
                Console.WriteLine("Kitap bulunamadı.");
                return;
            }

            kitaplar.Remove(kitap);
            Console.WriteLine("Kitap başarıyla silindi.");
        }
    }
}