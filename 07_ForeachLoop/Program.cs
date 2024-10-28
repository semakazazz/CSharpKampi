using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach(1;2;3;4)

            //1-değişken türü
            //2-değişken adı
            //3-in
            //4-liste, koleksiyon, dizi

            //string[] cities = { "roma", "milano", "ankara" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 28, 87, 45, 98, 23 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 28, 87, 45, 98, 23 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine(number);
            //}


            //int[] numbers = { 1, 28, 87, 45, 98, 23 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //foreach sadece dizilerde değil listelerde de çalışır.


            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Sınav sistemi uygulaması
            //Console.WriteLine("***** c# eğitim kampı sınav uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------------");
            //Console.Write("sınıfta kaç öğrenci var: ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------------");

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //her öğrenci için 3 sınav girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notu girinin: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topladık.

            //    }
            //    studentExamAvg[i] = totalExamResult/3;
            //}
            //sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //}

            #endregion

            Console.Read();

        }
    }
}
