using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çiçek_satış1
{
    class Program
    {
        static void Main(string[] args)
        {
            int seçim;
            string çiçektür = "";
            double birimfiyat = 0.0;
            int stokkaranfil = 0, stokpapatya = 0, stokgül = 0, stokorkide = 0, stok = 0;
            int menü = 0;

            Console.WriteLine("-----MENÜ-----Çiçek Master v2.0");
            Console.WriteLine("1.satış yap");
            Console.WriteLine("2.çık");
            Console.WriteLine("--------------------");
            Console.WriteLine("seçiminiz=");
            menü = Convert.ToInt32(Console.ReadLine());

            switch (menü)
            {
                case 1:

                    Console.WriteLine("ürünler için stok bilgilerini giriniz:");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("papatya="); stokpapatya = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("karanfil="); stokkaranfil = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("gül="); stokgül = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("orkide="); stokorkide = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------------------");

                    Console.WriteLine("-------çiçekler-----");
                    Console.WriteLine("1.papatya");
                    Console.WriteLine("2.karanfil");
                    Console.WriteLine("3.gül");
                    Console.WriteLine("4.orkide");
                    Console.WriteLine("5.vazgeç");
                    Console.WriteLine("---------------------");
                    Console.Write("seçiminiz=");
                    seçim = Convert.ToInt32(Console.ReadLine());

                    string müşterifirmaadı, müşterifirmaadresi, müşterifirmatelefon, müşterifirmavergino;
                    Console.WriteLine("müşteri firma bilgilerini giriniz:");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("isim="); müşterifirmaadı = (Console.ReadLine());
                    Console.WriteLine("adres="); müşterifirmaadresi = (Console.ReadLine());
                    Console.WriteLine("tel="); müşterifirmatelefon = (Console.ReadLine());
                    Console.WriteLine("vergi no="); müşterifirmavergino = (Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------------------");


                    if (seçim != 5)
                    {
                        if (seçim == 1)
                        {
                            çiçektür = "papatya";
                            birimfiyat = 5;
                            stok = stokpapatya;
                        }
                        else if (seçim == 2)
                        {
                            çiçektür = "karanfil";
                            birimfiyat = 7;
                            stok = stokkaranfil;
                        }
                        else if (seçim == 3)
                        {
                            çiçektür = "gül";
                            birimfiyat = 10;
                            stok = stokgül;
                        }
                        else if (seçim == 4)
                        {
                            çiçektür = "orkide";
                            birimfiyat = 15;
                            stok = stokorkide;

                        }
                        else
                        {
                            Console.WriteLine("hatalı çiçek seçimi yaptınız:");
                            Console.Read();
                            return;
                        }
                        Console.WriteLine(çiçektür + "birimfiyatı=" + birimfiyat);



                        Console.WriteLine("kaç adet" + çiçektür + "satılacak?");
                        int adet = Convert.ToInt32(Console.ReadLine());

                        if (adet > stok)
                        {
                            Console.WriteLine(çiçektür + "için" + stok + "stok adedini aştınız!");
                            Console.Read();
                            return;
                        }
                        double adetiskonto = 0.0;


                        if (çiçektür == "papatya")
                        {
                            if (adet >= 50 && adet <= 100)
                                adetiskonto = 10;
                            else if (adet >= 101 && adet <= 200)
                                adetiskonto = 25;
                            else
                                adetiskonto = 30;
                        }
                        else if (çiçektür == "karanfil")
                        {
                            if (adet >= 40 && adet <= 80)
                                adetiskonto = 5;
                            else if (adet >= 81 && adet <= 150)
                                adetiskonto = 10;
                            else
                                adetiskonto = 20;
                        }
                        else if (çiçektür == "gül")
                        {
                            if (adet >= 30 && adet <= 60)
                                adetiskonto = 5;
                            else if (adet >= 61 && adet <= 100)
                                adetiskonto = 10;
                            else
                                adetiskonto = 15;
                        }
                        else if (çiçektür == "orkide")
                        {
                            if (adet >= 20 && adet <= 50)
                                adetiskonto = 5;
                            else
                                adetiskonto = 10;
                        }

                        Console.WriteLine("ekstra iskonta (yok is 0 girin):");
                        double ekstraiskonta = Convert.ToDouble(Console.ReadLine());

                        double hamfiyat, indirim1, fiyat1, indirim2, fiyat2, kdv, kdvoran = 18, toplamfiyat;

                        hamfiyat = adet * birimfiyat;

                        indirim1 = hamfiyat * (adetiskonto / 100);
                        fiyat1 = hamfiyat - indirim1;

                        indirim2 = fiyat1 * (ekstraiskonta / 100);
                        fiyat2 = fiyat1 - indirim2;

                        kdv = fiyat2 * (kdvoran / 100);
                        toplamfiyat = fiyat2 + kdv;


                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("**********************************************************************");
                        Console.WriteLine("*İNCİ ÇİÇEKÇİLİK LTD.ŞTİ.                   FATURA NO :10047         *");
                        Console.WriteLine("**********************************************************************");
                        Console.WriteLine("* ÜRÜN                ADET                         TUTAR             *");
                        Console.WriteLine("*--------------------------------------------------------------------*");
                        Console.WriteLine("*" + çiçektür.PadRight(25) + adet.ToString().PadRight(35) + hamfiyat.ToString().PadRight(16) + "*");
                        Console.WriteLine("*                                                                    *");
                        Console.WriteLine("*                                                                    *");
                        Console.WriteLine("*                                                                    *");
                        Console.WriteLine("*--------------------------------------------------------------------*");
                        Console.WriteLine("* Adet Bazlı İndirim Tutarı".PadRight(56) + indirim1.ToString("0.00").PadLeft(12) + "TL*");
                        Console.WriteLine("*Ara Toplam".PadRight(56) + fiyat1.ToString("0.00").PadLeft(12) + "TL*");
                        Console.WriteLine("*Ekstra İndirim Tutarı".PadRight(56) + indirim2.ToString("0.00").PadLeft(12) + "TL*");
                        Console.WriteLine("*Toplam (KDV Hariç)".PadRight(56) + fiyat2.ToString("0.00").PadLeft(12) + "TL*");
                        Console.WriteLine("*KDV".PadRight(56) + kdv.ToString("0.00").PadLeft(12) + "TL*");
                        Console.WriteLine("*Toplam".PadRight(56) + toplamfiyat.ToString("0.00").PadLeft(12) + "TL*");
                        Console.WriteLine("***********************************************************************");
                        Console.WriteLine("*  Müşteri Firma Bilgileri                                            *");
                        Console.WriteLine("*---------------------------------------------------------------------*");
                        Console.WriteLine("*" + müşterifirmaadı.PadRight(68) + "*");
                        Console.WriteLine("*adres:" + müşterifirmaadresi.PadRight(63) + "*");
                        Console.WriteLine("*telefon:" + müşterifirmatelefon.PadRight(60) + "*");
                        Console.WriteLine("*vergi no:" + müşterifirmavergino.PadRight(59) + "*");
                        Console.WriteLine("*                                                                      *");
                        Console.WriteLine("************************************************************************");
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("hoşçakalın");
                    break;
                default:
                    Console.WriteLine("hatalı seçim yaptınız:");
                    Console.WriteLine("hoşçakalın:");
                    break;





            }
            Console.Read();
        }
    }
}
        