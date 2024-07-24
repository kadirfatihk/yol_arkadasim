using System;
using System.Net.Security;
namespace YolArkadasim
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------- YOL ARKADAŞIM UYGULAMASI -------");
                Console.WriteLine("Lütfen bir lokasyon seçiniz: \n1- Bodrum -> Paket başlangıç fiyatı 4000TL\n2- Marmaris -> Paket başlkangıç fiyatı 3000TL\n3- Çeşme -> Paket başlangıç fiyatı 5000TL");

                Console.WriteLine("*************************************************************");
                Console.Write("Lokasyon: "); string kullanici_lokasyon = Console.ReadLine().ToLower();
                
                Console.WriteLine("*************************************************************");
                // if yapısını while döngüsü içine alarak yanlış verilen cevaplarda soru tekrarını sağladım.
                while (kullanici_lokasyon != "bodrum" && kullanici_lokasyon != "marmaris" && kullanici_lokasyon != "çeşme")
                {
                    Console.Write("Lütfen geçerli bir değer girin: "); string yeni_lokasyon = Console.ReadLine();
                    kullanici_lokasyon = yeni_lokasyon;
                }
                if (kullanici_lokasyon == "bodrum")
                {
                    Console.WriteLine("Bodrum'a; güneşli koyları, tarihi kalıntıları ve hareketli gece hayatıyla unutulmaz bir tatil deneyimi için gidilir.");
                }
                else if (kullanici_lokasyon == "marmaris")
                {
                    Console.WriteLine("Marmaris'e; yemyeşil çam ormanlarıyla çevrili turkuaz koylarda deniz, kum ve güneşin tadını çıkarırken aynı zamanda canlı gece hayatına da doymak için gidilir.");
                }
                else if (kullanici_lokasyon == "çeşme")
                {
                    Console.WriteLine("Çeşme'ye; rüzgar sörfünden şık beach clublara, tarihi sokaklardan enfes Ege lezzetlerine kadar her zevke hitap eden bir tatil cenneti deneyimi için gidilir.");
                }
                Console.WriteLine("*************************************************************");

                Console.Write("Kişi sayısı: "); int kisi_sayisi = Convert.ToInt32(Console.ReadLine());

                // burada da aynı şekilde yanlış girilen cevaplara karşı soru tekrarını sağladım.
                Console.WriteLine("Tatile hangi ulaşım yolu ile gideceksiniz ? Lütfen aşağıdaki seçeneklerden sadece birini seçiniz(1 veya 2 olarak seçim yapınız)\n1- Kara Yolu -> Kişi başı ulaşım tutarı gidiş-dönüş 1500TL\n2- Hava Yolu -> Kişi başı ulaşım tutarı gidiş-dönüş 4000TL.");
                Console.Write("Ulaşım aracı: "); int ulasim_araci = Convert.ToInt32(Console.ReadLine());

                while (ulasim_araci != 1 && ulasim_araci != 2)
                {
                    Console.Write("Geçerli bir değer girin: "); int yeni_ulasim = Convert.ToInt32(Console.ReadLine());
                    ulasim_araci = yeni_ulasim;
                }
                if (ulasim_araci == 1)
                {
                    Console.WriteLine("Kara yolu seçildi. Ücret -> 1500TL");
                }
                else if (ulasim_araci == 2)
                {
                    Console.WriteLine("Hava yolu seçildi. Ücret -> 4000TL");
                }

                Console.WriteLine("*************************************************************");

                // lokasyon ve ulaşım ücretleri hesaplama.
                int lokasyon_ucret = 0;
                if (kullanici_lokasyon == "bodrum")
                {
                    lokasyon_ucret = 4000;
                }
                else if (kullanici_lokasyon == "marmaris")
                {
                    lokasyon_ucret = 3000;
                }
                else if (kullanici_lokasyon == "çeşme")
                {
                    lokasyon_ucret = 5000;
                }

                int ulasim_ucret = 0;
                if (ulasim_araci == 1)
                {
                    ulasim_ucret = kisi_sayisi * 1500;
                }
                else if (ulasim_araci == 2)
                {
                    ulasim_ucret = kisi_sayisi * 4000;
                }

                Console.WriteLine("*************************************************************");

                // toplam fiyat.
                int toplam_fiyat = lokasyon_ucret + ulasim_ucret;
                Console.WriteLine($"Toplam Fiyat-> Lokasyon Ücreti: {lokasyon_ucret} TL + Ulaşım Ücreti: {ulasim_ucret} TL = {toplam_fiyat} TL");

                Console.WriteLine("Başka bir işlem yapmak ister misiniz? (evet veya hayır)");
                string cevap = Console.ReadLine().ToLower();
                if (cevap == "evet")
                {
                    continue;
                }
                else if (cevap == "hayır")
                {
                    Console.WriteLine("iyi günler.");
                    break;
                }
                else
                {
                    Console.WriteLine("geçersiz giriş.");
                }
            }
        }
    }
}