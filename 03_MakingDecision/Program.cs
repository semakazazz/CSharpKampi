using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("lütfen şifreyi giriniz: " );
            //string password=Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, country;

            //Console.Write("başkenti girin: ");
            //capital = Console.ReadLine();
            //Console.Write("ülkeyi girin: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.Write("sayıyı gir: ");
            //number=int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.Write("sayı doğru");
            //}
            //else
            //{
            //    Console.Write("sayı hatalı");
            //}


            //int exam1, exam2,exam3,average;
            //string result="hata";
            //Console.Write("sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("sınav2: ");
            //exam2=int.Parse(Console.ReadLine());
            //Console.Write("sınav3: ");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması: "+average);

            //if(average>0 & average<=50)
            //{
            //    result = "sonuç vasat";
            //}
            //if(average>50 & average<=70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}

            // Console.WriteLine(result);


            //string city;
            //Console.Write("lütfen şehir giriniz: ");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil.");
            //}

            //Console.Write("kullanıcı adı girin: ");
            //string username=Console.ReadLine();
            //if(username != "admin" )
            //{
            //    Console.Write("bu kulllanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz.");
            //}

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı girin: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı girin:");
            //int number2=int.Parse(Console.ReadLine());  

            //int result=number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan : "+result);

            //Console.Write("lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if(number % 2 ==0)
            //{
            //    Console.Write("sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.WriteLine("takım sembolünü girin: ");
            //team=char.Parse(Console.ReadLine());

            //if(team=='g' | team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team=='f' | team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team=='b' | team=='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** c# eğitim kampı restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine(" 1-ana yemekler \n 2-çorbalar \n 3-pizzalar \n 4-içecekler \n 5-tatlılar" );
            //Console.WriteLine("---------------------");

            //string menuItem;
            //Console.Write("detayını görmek istedğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------- Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-tavuk");
            //    Console.WriteLine("2-kızartma");
            //    Console.WriteLine("3-fasulye pilav");
            //    Console.WriteLine("4-fırında somon");
            //    Console.WriteLine("5-patlıcan musakka");
            //    Console.WriteLine("--------- Ana Yemekler------------");
            //}
            //if (menuItem == "2")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("--------- Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-mercimek");
            //    Console.WriteLine("2-ezogelin");
            //    Console.WriteLine("--------- Çorbalar------------");
            //}
            //if (menuItem == "3")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("--------- Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-akdeniz");
            //    Console.WriteLine("2-margarita");
            //    Console.WriteLine("3-tavuklu");
            //    Console.WriteLine("--------- Pizzalar ------------");

            //    Console.WriteLine();
            //    Console.WriteLine("--------- Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-tavuk");
            //    Console.WriteLine("2-kızartma");
            //    Console.WriteLine("3-fasulye pilav");
            //    Console.WriteLine("4-fırında somon");
            //    Console.WriteLine("5-patlıcan musakka");
            //    Console.WriteLine("--------- Ana Yemekler------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------- İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kola");
            //    Console.WriteLine("2-ayran");
            //    Console.WriteLine("3-su");
            //    Console.WriteLine("--------- İçecekler------------");

            //}
            //if (menuItem == "5")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("--------- Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-triliçe");
            //    Console.WriteLine("2-kazandibi");
            //    Console.WriteLine("3-sütlaç");
            //    Console.WriteLine("--------- Tatlılar ------------");

            //}
            #endregion

            #region Switch Case

            //Console.Write("ay girişi yapın: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("ocak"); break;
            //    case 2: Console.Write("şubat"); break;
            //    case 3: Console.Write("mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("eylül"); break;
            //    case 10: Console.Write("ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("aralık"); break;
            //    default: Console.Write("hatalı veri girişi"); break ;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. sayı: ");
            //number1 =int.Parse(Console.ReadLine());
            //Console.Write("2.sayı: ");
            //number2 =int.Parse(Console.ReadLine());
            //Console.Write("yapmak istedğiniz işlem: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1+ number2;
            //        Console.WriteLine(result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine(result); 
            //            break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine(result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine(result);
            //        break;

            }





























            #endregion








           // Console.ReadLine();











        }
    }
}
