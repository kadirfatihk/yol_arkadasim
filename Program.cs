using System;

namespace YolArkadasim
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------- YOL ARKADAŞIM UYGULAMASI -------\n");
                Console.WriteLine("Lütfen bir lokasyon seçiniz:");
                Console.WriteLine("1- Bodrum");
                Console.WriteLine("2- Marmaris");
                Console.WriteLine("3- Çeşme\n");

                Console.Write("Seçtiğiniz lokasyonu yazın: ");
                string kullaniciLokasyon = Console.ReadLine().ToLower();

                int lokasyonUcreti = 0;
                string lokasyonBilgisi = "";

                while (true)
                {
                    if (kullaniciLokasyon == "bodrum")
                    {
                        lokasyonUcreti = 4000;
                        lokasyonBilgisi = "Bodrum'a; güneşli koyları, tarihi kalıntıları ve hareketli gece hayatıyla unutulmaz bir tatil deneyimi için gidilir.";
                        break;
                    }
                    else if (kullaniciLokasyon == "marmaris")
                    {
                        lokasyonUcreti = 3000;
                        lokasyonBilgisi = "Marmaris'e; yemyeşil çam ormanlarıyla çevrili turkuaz koylarda deniz, kum ve güneşin tadını çıkarırken aynı zamanda canlı gece hayatına da doymak için gidilir.";
                        break;
                    }
                    else if (kullaniciLokasyon == "çeşme")
                    {
                        lokasyonUcreti = 5000;
                        lokasyonBilgisi = "Çeşme'ye; rüzgar sörfünden şık beach clublara, tarihi sokaklardan enfes Ege lezzetlerine kadar her zevke hitap eden bir tatil cenneti deneyimi için gidilir.";
                        break;
                    }
                    else
                    {
                        Console.Write("Geçersiz lokasyon. Tekrar yazın: ");
                        kullaniciLokasyon = Console.ReadLine();
                    }
                }

                Console.WriteLine("\n" + lokasyonBilgisi + "\n");

                Console.Write("Kişi sayısı: ");
                int kisiSayisi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nTatile hangi ulaşım yolu ile gideceksiniz?");
                Console.WriteLine("1- Kara Yolu -> Kişi başı ulaşım tutarı gidiş-dönüş 1500TL");
                Console.WriteLine("2- Hava Yolu -> Kişi başı ulaşım tutarı gidiş-dönüş 4000TL");
                Console.Write("Seçiminizi yapın (1-2): ");
                string ulasimSecim = Console.ReadLine();

                int ulasimUcreti = 0;

                while (true)
                {
                    if (ulasimSecim == "1")
                    {
                        ulasimUcreti = 1500 * kisiSayisi;
                        Console.WriteLine("\nKara yolu seçildi.");
                        break;
                    }
                    else if (ulasimSecim == "2")
                    {
                        ulasimUcreti = 4000 * kisiSayisi;
                        Console.WriteLine("\nHava yolu seçildi.");
                        break;
                    }
                    else
                    {
                        Console.Write("Geçersiz seçim. Tekrar girin (1-2): ");
                        ulasimSecim = Console.ReadLine();
                    }
                }

                int toplamFiyat = lokasyonUcreti + ulasimUcreti;
                Console.WriteLine($"\n{kullaniciLokasyon} için {kisiSayisi} kişilik tatilin toplam fiyatı: {toplamFiyat} TL");

                Console.Write("\nBaşka bir işlem yapmak ister misiniz? (evet/hayır): ");
                string cevap = Console.ReadLine().ToLower();

                if (cevap != "evet")
                {
                    Console.WriteLine("İyi günler dileriz!");
                    break;
                }

                Console.WriteLine("\n------------------------------\n");
            }
        }
    }
}