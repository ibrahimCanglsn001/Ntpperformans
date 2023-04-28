using System;

namespace ConsoleApp1
{
    class restoran
    {
        string menu;
        double secim;
        double adet;
        double toplam = 0;
        public void Menu()
        {

            double secim, adet;
            toplam = 0;
            double hesap = 0;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("| Yemekler <> İçecekler                                |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("| 1-Et Döner - 40 TL -- 7-Ayran - 5 TL                 |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("| 2-Tavuk Döner - 25 TL -- 8-Kola - 7.50 TL            |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("| 3-Çorbalar - 10 TL -- 9-Su - 3 TL                    |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("| 4-Salatalar - 80 TL -- 10-Çay - 5 TL                 |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("| 5-Pilav - 22 TL -- 11-Fanta - 7.50 TL                |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("| 6-Pide - 30 TL -- 12-Soda - 7 TL                     |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("--------------------------------------------------------");
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("");
                Console.Write("Alacağınız Ürünün Numarası:");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Kaç Porsiyon Et Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 40;
                    hesap = hesap + toplam;
                }
                else if (secim == 2)
                {
                    Console.Write("Kaç Porsiyon Tavuk Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    hesap = hesap + toplam;
                }
                else if (secim == 3)
                {
                    Console.Write("Kaç Porsiyon Çorba: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = hesap + toplam;
                }
                else if (secim == 4)
                {
                    Console.Write("Kaç Porsiyon Salata: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 80;
                    hesap = hesap + toplam;
                }
                else if (secim == 5)
                {
                    Console.Write("Kaç Porsiyon Kuru Pilav: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 22;
                    hesap = hesap + toplam;
                }
                else if (secim == 6)
                {
                    Console.Write("Kaç Porsiyon Pide: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 30;
                    hesap = hesap + toplam;
                }
                else if (secim == 7)
                {
                    Console.Write("Kaç Adet Ayran: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }
                else if (secim == 8)
                {
                    Console.Write("Kaç Adet Kola: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7.50;
                    hesap = hesap + toplam;
                }
                else if (secim == 9)
                {
                    Console.Write("Kaç Adet Su: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3;
                    hesap = hesap + toplam;
                }
                else if (secim == 10)
                {
                    Console.Write("Kaç Adet Çay: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }
                else if (secim == 11)
                {
                    Console.Write("Kaç Adet Fanta: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7.50;
                    hesap = hesap + toplam;
                }
                else if (secim == 12)
                {
                    Console.Write("Kaç Adet Soda: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap = hesap + toplam;
                }
                else

                    Console.WriteLine("Böyle Bir Şeçim Yok...");
                Console.WriteLine();

                Console.Write("Başka Bir İsteğiniz Var Mı : ");
                Console.WriteLine();

                string cevap = Console.ReadLine();
                if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "HAYIR" || cevap == "hayır")

                    break;
            }
            Console.WriteLine("Toplam Tutar : " + hesap);
            Console.WriteLine();

            Console.Write("Verilen Para : ");
            double a = double.Parse(Console.ReadLine());

            double b = a - hesap;
            Console.WriteLine();

            Console.Write("Para Üstü : " + b);
            Console.WriteLine();

            if (b < 0)
            {
                Console.WriteLine("Para Üstü Yok...");
            }

            if (a < hesap)
            {
                Console.WriteLine("Malesef Paranız Yetmiyor");
                Console.WriteLine();
                Console.WriteLine("Şu Kadar Eksik : " + b);
            }
            else
            {
                Console.WriteLine("Afiyet Olsun .....");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            restoran r1 = new restoran();

            r1.Menu();

            Console.ReadKey();
        }

    }
}