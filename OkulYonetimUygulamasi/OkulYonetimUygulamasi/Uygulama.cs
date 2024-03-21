using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
{
    class Uygulama
    {
        static Okul Okul = new Okul();
        int sayac = 0;

        public void Calistir()
        {

            SahteVeriGir();
            Menu();


            while (true)
            {
                Console.WriteLine();
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                        TümOgrencileriListele();
                        break;
                    case "2":
                        SubeyeGoreListele();
                        break;
                    case "3":
                        CinsiyeteGoreListele();
                        break;
                    case "4":
                        TarihtenSonraDoganlar();
                        break;
                    case "5":
                        IllereGoreListele();
                        break;
                    case "6":
                        NotlariGoster();
                        break;
                    case "7":
                        KitapListele();
                        break;
                    case "8":
                        OkulEnBasariliBes();
                        break;
                    case "9":
                        OkulEnBasarisizUc();
                        break;
                    case "10":
                        SubeEnBasariliBes();
                        break;
                    case "11":
                        SubeEnBasarisizUc();
                        break;
                    case "12":
                        OrtalamaGoster();
                        break;
                    case "13":
                        SinifinOrtalamasi();
                        break;
                    case "14":
                        SonKitap();
                        break;
                    case "15":
                        OgrenciGir();
                        break;
                    case "16":
                        Guncelle();
                        break;
                    case "17":
                        OgrenciSil();
                        break;
                    case "18":
                        AdresGir();
                        break;
                    case "19":
                        KitapGir();
                        break;
                    case "20":
                        NotGir();
                        break;

                    case "CİKİS":
                    case "ÇIKIŞ":
                        Cikis();
                        break;
                    case "LİSTE":
                        Console.WriteLine();
                        Menu();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        sayac++;
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Menüyü tekrar listelemek için \"liste\", çıkış yapmak için \"çıkış\" yazın.");
            }

        }
        public void Menu()
        {
            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----");
            Console.WriteLine();
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20 - Öğrencinin notunu gir");
            Console.WriteLine();
            Console.WriteLine("çıkış yapmak için \"çıkış\" yazıp \"enter\"a basın.");
        }
        public string SecimAl()
        {
            if (sayac != 10)
            {
                Console.Write("Yapmak istediginiz islemi seçiniz: ");
                return Console.ReadLine().ToUpper();
            }
            else
            {
                Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                return "ÇIKIŞ";
            }


        }
        public void Cikis()
        {
            Environment.Exit(0);
        }
        public void SahteVeriGir()
        {
            SahteOgrenciGir();
            SahteNotGir();
            SahteAdresGir();
            SahteKitapEkle();
        }

        public void SahteOgrenciGir()
        {
            Okul.OgrenciEkle(1, "Elif", "Selçuk", new DateTime(2001, 5, 5), CINSIYET.Kiz, SUBE.A);
            Okul.OgrenciEkle(2, "Betül", "Yılmaz", new DateTime(2000, 10, 2), CINSIYET.Kiz, SUBE.B);
            Okul.OgrenciEkle(3, "Hakan", "Çelik", new DateTime(2001, 8, 12), CINSIYET.Erkek, SUBE.C);
            Okul.OgrenciEkle(4, "Kerem", "Akay", new DateTime(2002, 6, 10), CINSIYET.Erkek, SUBE.A);
            Okul.OgrenciEkle(5, "Hatice", "Çınar", new DateTime(2000, 6, 5), CINSIYET.Kiz, SUBE.B);
            Okul.OgrenciEkle(6, "Selim", "İleri", new DateTime(2004, 7, 20), CINSIYET.Erkek, SUBE.B);
            Okul.OgrenciEkle(7, "Selin", "Kamış", new DateTime(2002, 5, 20), CINSIYET.Kiz, SUBE.C);
            Okul.OgrenciEkle(8, "Sinan", "Avcı", new DateTime(2003, 2, 15), CINSIYET.Erkek, SUBE.A);
            Okul.OgrenciEkle(9, "Deniz", "Çoban", new DateTime(2000, 2, 2), CINSIYET.Erkek, SUBE.C);
            Okul.OgrenciEkle(10, "Selda", "Kavak", new DateTime(1999, 9, 20), CINSIYET.Kiz, SUBE.B);

        }
        public void SahteNotGir()
        {
            string[] dizi = new string[4];
            dizi[0] = "Türkçe";
            dizi[1] = "Matematik";
            dizi[2] = "Fen";
            dizi[3] = "Sosyal";
            Random rnd = new Random();

            for (int i = 1; i <= 10; i++)
            {
                for (int d = 0; d < 4; d++)
                {
                    Okul.NotEkle(i, dizi[d], rnd.Next(0, 100));
                }
            }
        }
        public void SahteAdresGir()
        {

            Okul.AdresEkle(1, "Ankara", "Çankaya", "Bağlıca");
            Okul.AdresEkle(2, "Ankara", "Keçiören", "Osmangazi");
            Okul.AdresEkle(3, "Ankara", "Çankaya", "Çukurambar");
            Okul.AdresEkle(4, "İzmir", "Karşıyaka", "Alaybey");
            Okul.AdresEkle(5, "İzmir", "Gaziemir", "Atıfbey");
            Okul.AdresEkle(6, "İzmir", "Gaziemir", "Irmak");
            Okul.AdresEkle(7, "İzmir", "Bayraklı", "Adalet");
            Okul.AdresEkle(8, "İstanbul", "Arnavutköy", "Anadolu");
            Okul.AdresEkle(9, "İstanbul", "Beykoy", "Acarlar");
            Okul.AdresEkle(10, "İstanbul", "Ataşehir", "Atatürk");

        }
        public void SahteKitapEkle()
        {

            string[] kitaplar = new string[19];
            kitaplar[0] = ("Ölü Ozanlar Derneği");
            kitaplar[1] = ("George Orwell- 1984");
            kitaplar[2] = ("Bülbülü Öldürmek");
            kitaplar[3] = ("Hayvan Çiftliği");
            kitaplar[4] = ("Harry Potter ve Felsefe Taşı");
            kitaplar[5] = ("Çavdar Tarlasında Çocuklar");
            kitaplar[6] = ("Büyük Umutlar");
            kitaplar[7] = ("Gurur ve Ön Yargı");
            kitaplar[8] = ("Jane Eyre");
            kitaplar[9] = ("Uğultulu Tepeler");
            kitaplar[10] = ("Frankenstein");
            kitaplar[11] = ("Kuşların Şarkısı");
            kitaplar[12] = ("Noel Şarkısı");
            kitaplar[13] = ("Harry Potter Sırlar Odası");
            kitaplar[14] = ("Harry Potter Azkaban Tutsağı");
            kitaplar[15] = (" Bir Ses Böler Geceyi");
            kitaplar[16] = ("Masal Masal İçinde");
            kitaplar[17] = ("Sis ve Gece");
            kitaplar[18] = ("Agatha'nın Anahtarı ");

            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Okul.KitapEkle(i, kitaplar[rnd.Next(0, 19)]);
            }
        }
        public void Listele(List<Ogrenci> liste)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine("Listelenecek ögrenci yok.");
                return;
            }

            Console.WriteLine("Sube".PadRight(10, ' ') + "No".PadRight(10, ' ') +
               "Adı" + " " + "Soyadı".PadRight(21, ' ') +
               "Not Ort.".PadRight(15, ' ') + "Okuduğu Kitap Say.");

            Console.WriteLine("".PadRight(79, '-'));

            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item.Sube.ToString().PadRight(10, ' ') +
                    item.No.ToString().PadRight(10, ' ') +
                    (item.Ad + " " + item.Soyad).PadRight(25, ' ') +
                    item.Ortalama.ToString().PadRight(15, ' ')
                    + item.KitapSayisi);
            }

        }
        public void TümOgrencileriListele()  //  1
        {
            Console.WriteLine();
            Console.WriteLine("1-Bütün Ögrencileri Listele --------------------------------------------------");

            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
                return;
            }

            Console.WriteLine();
            Listele(Okul.Ogrenciler);

        }
        public void SubeyeGoreListele()   //  2
        {
            Console.WriteLine();
            Console.WriteLine("2-Subeye Göre Ögrencileri Listele --------------------------------------------");

            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
                return;
            }

            SUBE sb = AracGerecler.SubeAl("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            List<Ogrenci> liste = Okul.Ogrenciler.Where(item => item.Sube == sb).ToList();

            Console.WriteLine();
            Listele(liste);
        }
        public void CinsiyeteGoreListele()  //  3
        {
            Console.WriteLine();
            Console.WriteLine("3-Cinsiyete Göre Öğrencileri Listele -----------------------------------------");

            CINSIYET cins = AracGerecler.KizMiErkekMi("Listelemek istediğiniz cinsiyeti girin (K/E): ");
            List<Ogrenci> liste = Okul.Ogrenciler.Where(a => a.Cinsiyet == cins).ToList();

            Console.WriteLine();
            Listele(liste);
        }
        public void TarihtenSonraDoganlar()   //  4
        {
            Console.WriteLine();
            Console.WriteLine("4-Dogum Tarihine Göre Ögrencileri Listele ------------------------------------");


            DateTime tarih = AracGerecler.TarihAl("Hangi tarihten sonraki ögrencileri listelemek istersiniz: ");
            List<Ogrenci> liste = Okul.Ogrenciler.Where(a => a.DogumTarihi > tarih).ToList();

            Console.WriteLine();
            Listele(liste);
        }
        public void IllereGoreListele()   //   5
        {
            Console.WriteLine();
            Console.WriteLine("5-Illere Göre Ögrencileri Listele --------------------------------------------");

            List<Ogrenci> liste = Okul.Ogrenciler.OrderBy(a => a.Adresi.Il).ToList();

            Console.WriteLine();
            Listele1(liste);

        }
        public void Listele1(List<Ogrenci> liste)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
                return;
            }
            
            Console.WriteLine("Sube".PadRight(10, ' ') +
                              "No".PadRight(10, ' ') + ("Adı" + " " + "Soyadı").PadRight(21, ' ') +
                              "Sehir".PadRight(15, ' ') + "Semt");

            Console.WriteLine("".PadRight(79, '-'));

            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item.Sube.ToString().PadRight(10, ' ') +
                                  item.No.ToString().PadRight(10, ' ') +
                                  (item.Ad + " " + item.Soyad).PadRight(21, ' ') +
                                  item.Adresi.Il.PadRight(15, ' ') + item.Adresi.Ilce);
            }

        }
        public void NotlariGoster()   //   6
        {
            Console.WriteLine();
            Console.WriteLine("6-Ögrencinin notlarını görüntüle ---------------------------------------------");

            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
                return;
            }

            int no = NoAl();
            BilgiYazdir(no);

            List<DersNotu> list = Okul.OgrenciNotlariGetir(no);
            Listele2(list);
        }
        public int NoAl()
        {
            int no;
            
            do
            {
                no = AracGerecler.SayiAl("Ögrencinin numarasi: ");   // Sayi kontrol
                if (!Okul.VarMi(no))  // böyle bir ögrenci var mi?
                {
                    Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin.");
                    continue;
                }
                return no;
            } while (true);
        }
        public void BilgiYazdir(int no)
        {
            Console.WriteLine();
            Console.Write("Ögrencinin Adı Soyadı: ");
            Console.WriteLine(Okul.AdiSoyadiGetir(no));    // Ad-Soyad getir methodu
            Console.Write("Ögrencinin Subesi: ");
            Console.WriteLine(Okul.SubeGetir(no));        // Sube Getir methodu
            Console.WriteLine();
        }
        public void Listele2(List<DersNotu> liste)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine("Öğrenciye ait bir not bulunmamaktadır");
                return;
            }

            Console.WriteLine("Dersin Adi".PadRight(15, ' ') + "Notu");

            Console.WriteLine("".PadRight(20, '-'));

            foreach (DersNotu item in liste)
            {
                Console.WriteLine(item.DersAdi.ToString().PadRight(15) + item.Not);
            }
        }
        public void KitapListele()     //  7
        {
            Console.WriteLine();
            Console.WriteLine("7-Ögrencinin okudugu kitapları listele ---------------------------------------");

            int no = NoAl();
            BilgiYazdir(no);

            Listele3(Okul.KitapListele(no));
        }
        public void Listele3(List<string> liste)
        {

            if (liste !=null)
            {
                Console.WriteLine("Okudugu Kitaplar");

                Console.WriteLine("-----------------");

                foreach (string item in liste)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Öğrencinin okuduğu herhangi bir kitap bulunmamaktadır.");
            }
            
        }
        public void OkulEnBasariliBes()  //  8
        {
            Console.WriteLine();
            Console.WriteLine("8-Okuldaki en basarılı 5 ögrenciyi listele -----------------------------------");

            List<Ogrenci> liste = Okul.Ogrenciler.OrderByDescending(a => a.Ortalama).Take(5).ToList();

            Console.WriteLine();
            Listele(liste);
        }
        public void OkulEnBasarisizUc() //  9
        {
            Console.WriteLine();
            Console.WriteLine("9-Okuldaki en basarısız 3 ögrenciyi listele ----------------------------------");

            List<Ogrenci> liste = Okul.Ogrenciler.OrderBy(a => a.Ortalama).Take(3).ToList();

            Console.WriteLine();
            Listele(liste);

        }
        public void SubeEnBasariliBes() //  10
        {
            Console.WriteLine();
            Console.WriteLine("10-Subedeki en basarılı 5 ögrenciyi listele -----------------------------------");

            SUBE sb = AracGerecler.SubeAl("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            List<Ogrenci> liste = Okul.Ogrenciler.Where(item => item.Sube == sb).OrderByDescending(a => a.Ortalama).Take(5).ToList();

            Console.WriteLine();
            Listele(liste);
        }
        public void SubeEnBasarisizUc()  //  11
        {
            Console.WriteLine();
            Console.WriteLine("11-Subedeki en basarısız 3 ögrenciyi listele ----------------------------------");

            SUBE sb = AracGerecler.SubeAl("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            List<Ogrenci> liste = Okul.Ogrenciler.Where(item => item.Sube == sb).OrderBy(a => a.Ortalama).Take(5).ToList();

            Console.WriteLine();
            Listele(liste);
        }
        public void OrtalamaGoster()     //  12
        {
            Console.WriteLine();
            Console.WriteLine("12-Ögrencinin Not Ortalamasını Gör ----------------------------------");
           
            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
                return;
            }

            int no = NoAl();
            BilgiYazdir(no);

            Console.Write("Ögrencinin not ortalaması: " + Okul.OrtalamaGetir(no));
            Console.WriteLine();

        }
        public void SinifinOrtalamasi()  // 13  
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("13-Şubenin Not Ortalamasını Gör -------------------------------------");

                SUBE sube = AracGerecler.SubeAl("Bir şube seçin (A/B/C): ");
                Console.WriteLine();

                double ort = 0;
                ort = Okul.Ogrenciler.Where(a => a.Sube == sube).Average(a => a.Ortalama);

                Console.Write(sube + " subesinin not ortalaması: " + decimal.Round((decimal)ort, 2));  // virgülden sonra 2 digit göstersin diye
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
            }
            
        }
        public void SonKitap()  //  14  
        {
            Console.WriteLine();
            Console.WriteLine("14-Ögrencinin okudugu son kitabı listele ----------------------------");

            int no = NoAl();
            BilgiYazdir(no);

            List<string> Kitaplar = Okul.SonKitapGetir(no);

            if (Kitaplar != null)
            {
                Console.WriteLine("Ögrencinin Okudugu Son Kitap");
                Console.WriteLine("-----------------------------");

                foreach (string item in Kitaplar)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("Öğrencinin okuduğu herhangi bir kitap bulunmamaktadır.");
            }



        }
        public void OgrenciGir()    //   15
        {
            Console.WriteLine();
            Console.WriteLine("15-Öğrenci Ekle -----------------------------------------------------");
            int alinanno = AracGerecler.SayiAl("Ögrencinin numarası: ");
            int yenino = Okul.NoOlustur(alinanno);

            string yeniAd = IlkHarfiBuyut(AracGerecler.YaziAl("Ögrencinin adı: "));
            string yeniSoyad = IlkHarfiBuyut(AracGerecler.YaziAl("Ögrencinin soyadı: "));

            DateTime tarih = AracGerecler.TarihAl("Ögrencinin dogum tarihi: ");
            CINSIYET cins = AracGerecler.KizMiErkekMi("Ögrencinin cinsiyeti (K/E): ");
            SUBE sube = AracGerecler.SubeAl("Ögrencinin subesi (A/B/C): ");

            Okul.OgrenciEkle(yenino, yeniAd, yeniSoyad, tarih, cins, sube);
            Console.WriteLine();
            Console.WriteLine(yenino + " numaralı ögrenci sisteme basarılı bir sekilde eklenmistir.");

            if (alinanno != yenino)
            {
                Console.WriteLine($"Sistemde {alinanno} numaralı öğrenci olduğu için verdiğiniz öğrenci no {yenino} olarak değiştirildi. ");
            }
        }
        static string IlkHarfiBuyut(string veri)
        {
            string a = veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
            return a;
        }
        public void Guncelle()  //  16 
        {
            Console.WriteLine();
            Console.WriteLine("16-Ögrenci Güncelle -----------------------------------------------------------");

            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede güncellenecek ögrenci yok.");
                return;
            }

            int no = NoAl();
            string isim = AracGerecler.YaziAl("Ögrencinin adı: ");
            isim = IlkHarfiBuyut(isim);
            string soyisim = AracGerecler.YaziAl("Ögrencinin soyadı: ");
            soyisim = IlkHarfiBuyut(soyisim);
            DateTime tarih = AracGerecler.TarihAlGuncelle("Ögrencinin dogum tarihi: ");
            CINSIYET cins = AracGerecler.KizMiErkekMi("Ögrencinin cinsiyeti (K/E): ");
            SUBE sube = AracGerecler.SubeAl("Ögrencinin subesi (A/B/C): ");

            Okul.Guncelle(no, isim, soyisim, tarih, cins, sube);
            Console.WriteLine();
            Console.WriteLine("Ogrenci güncellendi.");

        }
        public void OgrenciSil()  //  17  
        {
            Console.WriteLine();
            Console.WriteLine("17-Ögrenci sil ----------------------------------------------------------------");

            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek ögrenci yok.");
                return;
            }

            int no = NoAl();
            BilgiYazdir(no);

            string secim = AracGerecler.YaziAl("Ögrenciyi silmek istediginize emin misiniz (E/H): ");  // sayi olup olmadigi kontrol edildi

            if (secim.ToUpper() == "E")
            {
                Okul.OgrenciSil(no);
                Console.WriteLine("Ögrenci basarılı bir sekilde silindi.");

            }
            else if (secim.ToUpper() == "H")
            {
                return;
            }

        }
        public void AdresGir()  //  18
        {
            Console.WriteLine();
            Console.WriteLine("18-Ögrencinin Adresini Gir ------------------------------------------");

            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
                return;
            }

            int no = NoAl();
            BilgiYazdir(no);

            string yeniIl = IlkHarfiBuyut(AracGerecler.YaziAl("Il: "));
            string yeniIlce = IlkHarfiBuyut(AracGerecler.YaziAl("Ilce: "));
            string yeniMah = IlkHarfiBuyut(AracGerecler.YaziAl("Mahalle: "));

            Okul.AdresEkle(no, yeniIl, yeniIlce, yeniMah);

            Console.WriteLine();
            Console.WriteLine("Bilgiler sisteme girilmistir.");

        }
        public void KitapGir()     //  19
        {
            Console.WriteLine();
            Console.WriteLine("19-Ögrencinin okudugu kitabı gir ------------------------------------");

            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
                return;
            }

            int no = NoAl();
            BilgiYazdir(no);

            Console.Write("Eklenecek Kitabin Adı: ");
            string kitap = IlkHarfiBuyut(Console.ReadLine());
            Okul.KitapEkle(no, kitap);

            Console.WriteLine("Bilgiler sisteme girilmistir.");

        }
        public void NotGir()       //   20 
        {
            Console.WriteLine();
            Console.WriteLine("20-Not Gir ----------------------------------------------------------");

            int no = NoAl();

            BilgiYazdir(no);

            string dersx = AracGerecler.DersGir();


            int adet = AracGerecler.SayiAl("Eklemek istediginiz not adedi: ");

            for (int i = 1; i <= adet; i++)
            {

                int not = AracGerecler.SayiAl(i + ". Notu girin: ");

                if (not < 0 || not > 100)
                {
                    Console.WriteLine("Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                    i--;
                    continue;
                }

                Okul.NotEkle(no, dersx, not);
            }
            Console.WriteLine();
            Console.WriteLine("Bilgiler sisteme girilmistir.");
        }


    }
}
