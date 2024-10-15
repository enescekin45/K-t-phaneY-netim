using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();
            int secim;

            do
            {
                Console.WriteLine("\n--- Kütüphane Yönetim Sistemi ---");
                Console.WriteLine("1. Kitap Ekle");
                Console.WriteLine("2. Kitapları Listele");
                Console.WriteLine("3. Kitap Ara");
                Console.WriteLine("4. Kitap Sil");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminizi yapın: ");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Write("Kitap Adı: ");
                        string kitapAdi = Console.ReadLine();
                        Console.Write("Yazar Adı: ");
                        string yazarAdi = Console.ReadLine();
                        Console.Write("ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Yayın Yılı: ");
                        int yayinYili = int.Parse(Console.ReadLine());

                        Kitap yeniKitap = new Kitap(kitapAdi, yazarAdi, isbn, yayinYili);
                        kutuphane.KitapEkle(yeniKitap);
                        break;

                    case 2:
                        kutuphane.KitaplariListele();
                        break;

                    case 3:
                        Console.Write("Aramak istediğiniz kitap adı: ");
                        string araAdi = Console.ReadLine();
                        kutuphane.KitapAra(araAdi);
                        break;

                    case 4:
                        Console.Write("Silmek istediğiniz kitabın ISBN numarası: ");
                        string silISBN = Console.ReadLine();
                        kutuphane.KitapSil(silISBN);
                        break;

                    case 5:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
                        break;
                }

            } while (secim != 5);
        }
    }
}
   