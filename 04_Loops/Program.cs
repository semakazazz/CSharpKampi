using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For  Döngüsü

            //int i;
            //for (i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3;i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("ekrana yazılmasını istediğiniz adedi girin: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);


            //int toplam = 0;
            //for(int i=1;i<=20;i++)
            //{
            //    if(i%2==0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);

            //int count=0;
            //for(int i=1;i<50;i++)
            //{
            //   if(i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium=1;
            //for(int i=1;i<=24;i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+". saat sonunda: "+bacterium);
            //}


            #endregion

            #region While Döngüsü

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1,toplam=0;
            //while(i<=10)
            //{
            //    toplam += i;
            //    Console.WriteLine("toplam: "+toplam);
            //    i++;
            //}

            #endregion

            #region Örnek Sınav Sorusu

            //int sayı;
            //Console.Write("3 basamaklı sayı giriniz: ");
            //sayı=int.Parse(Console.ReadLine());
            //int birler, onlar, yüzler;
            //int toplam;

            //birler = sayı % 10;
            //yüzler = sayı / 100;
            //onlar = (sayı % 100)/10;

            //Console.WriteLine(birler+"-"+onlar+"-"+yüzler);

            //toplam=birler+onlar+yüzler;
            //Console.WriteLine(toplam);

            #endregion

            Console.ReadKey();



















        }
    }
}
