using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
{
    class Okul
    {
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void OgrenciEkle(int no, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
            Ogrenci o = new Ogrenci();
            o.AdresEkle("-", "-", "-");

            o.No = no;
            o.Ad = ad;
            o.Soyad = soyad;
            o.DogumTarihi = dogumTarihi;
            o.Cinsiyet = cinsiyet;
            o.Sube = sube;

            Ogrenciler.Add(o);

        }
        public void NotEkle(int ogrenciNo, string ders, int not)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            if (o != null)
            {
                DersNotu dn = new DersNotu(ders, not);
                o.Notlar.Add(dn);
            }
        }

        public void AdresEkle(int no, string il, string ilce, string mahalle)  
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            if (o != null)
            {
                o.AdresEkle(il, ilce, mahalle);
            }
        }
        public void KitapEkle(int no, string kitapAdi)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                o.KitapEkle(kitapAdi);
            }
        }
        public bool VarMi(int no)
        {  
            return this.Ogrenciler.Where(a => a.No == no).FirstOrDefault() != null;
        }
        public string AdiSoyadiGetir(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            string tamIsim = "";

            if (o != null)
            {
                tamIsim = o.Ad + " " + o.Soyad;
            }

            return tamIsim;
        }
        public SUBE SubeGetir(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                return o.Sube;
            }
            return SUBE.Empty;

        }
        public List<DersNotu> OgrenciNotlariGetir(int no)     
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            List<DersNotu> notlar;

            if (o != null)
            {
                notlar = o.Notlar.ToList();
                return notlar;
            }
            return null;

        }
        public List<string> KitapListele(int no)   
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            List<string> kitaplar;

            if (o != null)
            {
                if (o.Kitaplar != null )
                {
                    kitaplar = o.Kitaplar.ToList();
                    return kitaplar;
                }              
            }
            return null;
        }
        public double OrtalamaGetir(int no)  
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                return o.Ortalama;
            }
            return 0;
        }
        public List<string> SonKitapGetir(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            List<string> kitaplar;


            if (o != null)
            {
                if (o.Kitaplar != null)
                {
                    kitaplar = o.Kitaplar.ToList();
                    kitaplar.Reverse();

                    return kitaplar.Take(1).ToList();
                }  
            }
            return null;
        }
        public int NoOlustur(int no) 
        {
            while (true)
            {
                if (VarMi(no))
                {
                    no++;
                }
                else
                {
                    return no;
                }
            }
        }
        public void Guncelle(int no, string isim, string soyisim, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)   
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                if (!string.IsNullOrEmpty(isim))
                {
                    o.Ad = isim;
                }
                if (!string.IsNullOrEmpty(soyisim))
                {
                    o.Soyad = soyisim;
                }
                if (dogumTarihi != DateTime.MinValue)
                {
                    o.DogumTarihi = dogumTarihi;
                }
                if (cinsiyet != CINSIYET.Empty)   
                {
                    o.Cinsiyet = cinsiyet;
                }
                if (sube != SUBE.Empty)  
                {
                    o.Sube = sube;
                }
            }
        }
        public void OgrenciSil(int no)   
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                Ogrenciler.Remove(o);
            }
        }
    }
}
