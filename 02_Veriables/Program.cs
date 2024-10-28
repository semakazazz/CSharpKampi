using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //  double number;
            //  number = 4.85;
            // Console.WriteLine(number);



            //Console.WriteLine("***** fiyat listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice=14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 8.98;
            //tomato = 7.23;
            //Console.WriteLine("---- elma birim fiyatı:" + applePrice);
            //Console.WriteLine("---- portakal birim fiyatı:" + orangePrice);
            //Console.WriteLine("---- çilek birim fiyatı:" + strawberryPrice);
            //Console.WriteLine("---- patates birim fiyatı:" + potato);
            //Console.WriteLine("---- domates birim fiyatı:" + tomato);
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram, orangeGram, potatoGram, tomatoGram, strawberryGram;
            //appleGram = 1.245;
            //orangeGram = 2.456;
            //strawberryGram = 0.567;
            //tomatoGram = 1.234;
            //potatoGram = 2.678;

            //double appleTotal=appleGram*applePrice;
            //double orangeTotal=orangeGram*orangePrice;
            //double strawberryTotal= strawberryGram*strawberryPrice;
            //double tomatoTotal = tomatoGram * tomato;
            //double potatoTotal = potatoGram * potato;

            //Console.WriteLine("alınan ürün: Elma - "+" birim fiyat: "+applePrice+" - gramaj: "+appleGram+" - toplam tutar: "+appleTotal);
            //Console.WriteLine("alınan ürün: Portakal - " + " birim fiyat: " + orangePrice + " - gramaj: " + orangeGram + " - toplam tutar: " + orangeTotal);
            //Console.WriteLine("alınan ürün: Çilek - " + " birim fiyat: " + strawberryPrice + " - gramaj: " + strawberryGram + " - toplam tutar: " + strawberryTotal);
            //Console.WriteLine("alınan ürün: Domates- " + " birim fiyat: " + tomato + " - gramaj: " + tomatoGram + " - toplam tutar: " + tomatoTotal);
            //Console.WriteLine("alınan ürün: Patates - " + " birim fiyat: " + potato + " - gramaj: " + potatoGram + " - toplam tutar: " + potatoTotal);

            //double shoppingTtotalPrice = appleTotal + strawberryTotal + orangeTotal + tomatoTotal + potatoTotal;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("alışveriş toplam tutar= "+shoppingTtotalPrice);





            #endregion

            #region Char Değişkenler

            //char ' ile tanımlanır.
            //char symbol = 's';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** csharp hava yolları yolcu bilgisi ****");
            //Console.WriteLine();
            //string passengerName,passengerIdentityNumber, passengerSurname, passengerDistrick, passengerCity, passengerAge;
            //Console.Write("yolcu adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("ilçe: ");
            //passengerDistrick = Console.ReadLine();
            //Console.Write("şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("yolcu tc no: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("yolcu tc no:"+passengerIdentityNumber + " - "+"yolcu ad soyad: "+passengerName+" "+passengerSurname+" "+passengerDistrick+" "+passengerCity+" "+passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoePrice = 1000, computerPrice = 20000, chairPrice, tvPrice;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine(" ayakkabı sayısını girin: ");
            //shoesCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("bilgisayar sayısını girin: ");
            //computerCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("sandalye sayısını girin: ");
            //chairCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("Tv sayısını girin: ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount + shoePrice + computerPrice * computerCount + tvPrice * tvCount + chairCount * chairPrice;
            //Console.WriteLine();

            //Console.WriteLine("toplam tutar: " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayu İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("1.sınav notu: ");
            //exam1 =double.Parse(Console.ReadLine());
            //Console.WriteLine("2.sınav notu: ");
            //exam2 =double.Parse(Console.ReadLine());
            //Console.WriteLine("3.sınav notu: ");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam3 + exam2 + exam1) / 3;

            //Console.WriteLine();
            //Console.WriteLine("sınav ortalamanız: "+result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("cinsiyet seçin: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("cinsiyetiniz: "+gender);


            #endregion

            Console.Read();
        }
    }
}
