﻿using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;         // 1 byte
            sbyte c = 5;        // 1 byte


            short sayi = 5;        // 2 byte
            ushort us = 5;      // 2 byte
            Int16 i16 = 2;      // 2 byte


            int i = 2;          // 4 byte
            Int32 i32 = 2;      // 4 byte
            Int64 i64 = 2;      // 8 byte


            uint ui = 2;        // 4 byte
            long l = 4;         // 8 byte
            ulong ul = 4;       // 8 byte



            float f = 5;        // 4 byte
            double d = 5;       // 8byte
            decimal de = 5;     // 16 byte


            char ch = '2';      // 2 byte
            string str = "Murathan";    //  Sınırsız


            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);


            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;


            // string ifadeler

            string str1 = string.Empty;
            str1 = "Murathan";
            string ad = "Murathan";
            string soyad = "Tandoğan";
            string tamIsim = $"{ad}{soyad}";

            // integer tanımlama Şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10 < 2;  // False 

            //Değişken Dönüşümüleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();

            Console.WriteLine(yeniDeger); // Çıktısı 40


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 40


            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");  // . yerine / da koyabilirsiniz   gün ay yıl
            string datetime2 = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(datetime);
            Console.WriteLine(datetime2);
            Console.ReadLine();

        }
    }
}
