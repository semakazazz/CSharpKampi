using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[1];
            //colors[0] = "kırmızı";
            //colors[1] = "mavi";
            //Console.Write(colors[0]);

            //string[] cities = new string[2];
            //cities[0] = " milano";
            //cities[1] = "lyon";
            //cities[2] = "kahire";
            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];
            //numbers[0] = 10;
            //numbers[1] = 298;
            //numbers[2] = 456; 
            //numbers[3] = 423;
            //Console.WriteLine(numbers[3]);

            //string[] cities = { "prag", "milano", "roma" };
            //Console.WriteLine(cities[1]);
            #endregion

            #region  Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "mavi", "yeşil", "mor", "gri" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 6, 65, 66, 98, 99 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //int[] numbers = { 56, 36, 98, 78, 90, 34, 27 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region  Dizi Metotlar

            //int[] numbers = { 56, 36, 98, 78, 90, 34, 27 };
            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            int[] numbers = { 56, 36, 98, 78, 90, 34, 27 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);












            #endregion

            Console.Read();




        }
    }
}
