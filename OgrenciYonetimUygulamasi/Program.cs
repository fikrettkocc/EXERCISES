using System;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciYonetimUygulamasi
{
    internal class Program
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>(); //tüm programın içinde kullanılır

        static void Main(string[] args)
        {
            Uygulama();
        }
        static void Uygulama()
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması ");
            Console.WriteLine("1 - Öğrenci Ekle(E)   ");
            Console.WriteLine("2 - Öğrenci Listele(L)");
            Console.WriteLine("3 - Öğrenci Sil(S)    ");
            Console.WriteLine("4 - Çıkış(X)          ");
            Console.WriteLine();
            SecimAl();
        }
        static void OgrenciEkle()
        {           
            Ogrenci o = new Ogrenci();
            Console.WriteLine("1 - Öğrenci Ekle----------");
            Console.WriteLine((ogrenciler.Count + 1) + "." + "Öğrenci ");
            Console.Write("No: ");
            o.No = Convert.ToInt32(Console.ReadLine());
            while (ogrenciler.Any(ogrenci => ogrenci.No == o.No))
            {
                Console.WriteLine("Girilen numara zaten kullanılıyor. Lütfen farklı bir numara girin.");
                Console.Write("No: ");
                o.No = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Adı: ");
            string ad = Console.ReadLine();
            o.Ad = ad.Substring(0, 1).ToUpper() + ad.Substring(1).ToLower();
            Console.Write("Soyadı: ");
            string soyad = Console.ReadLine();
            o.Soyad = soyad.Substring(0, 1).ToUpper() + soyad.Substring(1).ToLower();
            Console.Write("Şubesi: ");
            o.Sube = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz? (E / H) ");
            string giris = Console.ReadLine();
            Console.WriteLine();
            if (giris.ToUpper() == "E")
            {
                ogrenciler.Add(o);
                Console.WriteLine("Öğrenci eklendi.");
            }
            else

            {
                Console.WriteLine("Öğrenci eklenmedi. ");
            }

            Console.WriteLine();
        }
        static void OgrenciListele()
        {
            Console.WriteLine("2 - Öğrenci Listele---------------");
            Console.WriteLine();

            if (ogrenciler.Count > 0)
            {
                Console.WriteLine("Şube    No      Ad Soyad ");
                Console.WriteLine("----------------------------------");
                foreach (Ogrenci o in ogrenciler)
                {
                    string sube = o.Sube.ToString().PadRight(8);
                    string no = o.No.ToString().PadRight(8);
                    string adSoyad = (o.Ad + " " + o.Soyad).PadRight(12);
                    Console.WriteLine(sube + no + adSoyad);
                }
            }
            else
            {
                Console.WriteLine("Gösterilecek öğrenci yok.");
            }
            Console.WriteLine();
        }

        static void OgrenciSil()
        {
            if (ogrenciler.Count != 0)
            {
                Console.WriteLine("3 - Öğrenci Sil----------          ");
                Console.WriteLine("Silmek istediğiniz öğrencinin      ");
                Console.Write("No: ");
                int no = Convert.ToInt32(Console.ReadLine());
                foreach (Ogrenci item in ogrenciler)
                {
                    if (item.No == no)
                    {
                        Console.WriteLine("Adı: " + item.Ad);
                        Console.WriteLine("Soyadı: " + item.Soyad);
                        Console.WriteLine("Şubesi: " + item.Sube);
                        Console.WriteLine();
                        Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E / H) ");
                        string giris = Console.ReadLine().ToLower();
                        if (giris == "e")
                        {
                            ogrenciler.Remove(item);
                            Console.WriteLine("Öğrenci silindi.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci silinmedi.");
                        }
                    }
                }
            }

            else if (ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
            }
        }

        static void SecimAl()
        {
            int limit = 10;
            int baslangic = 0;

            while (baslangic < limit)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Seçiminiz: ");
                    string secim = Console.ReadLine();

                    switch (secim.ToUpper())
                    {
                        case "1":
                        case "E":
                            OgrenciEkle();
                            break;
                        case "2":
                        case "L":
                            OgrenciListele();
                            break;
                        case "3":
                        case "S":
                            OgrenciSil();
                            break;
                        case "4":
                        case "X":
                            return;
                    }
                    // İstenen karakterlerin bir listesini oluşturun
                    List<char> istenenKarakterler = new List<char> { '1', '2', '3', '4', 'X', 'L', 'S', 'E' };

                    if (secim.Length == 1 && istenenKarakterler.Contains(Char.ToUpper(secim[0])))
                    {
                        // Geçerli seçim yapıldıysa işlemleri gerçekleştirin

                        break;
                    }
                    else
                    {
                        // Hatalı giriş yapıldığında kullanıcıya mesaj verin
                        Console.WriteLine("Hatalı giriş yapıldı.");
                        baslangic++;

                        if (baslangic >= limit)
                        {
                            // Maksimum deneme sayısına ulaşıldığında programı sonlandırın
                            Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                        }
                    }
                }
            }
        }        
    }
}