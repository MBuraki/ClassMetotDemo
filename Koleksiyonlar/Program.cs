﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Burak","Songül","Kadriye","Fatma"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //new ile artık yukardakinden farklı yeni string
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); //İlkeri yazar
            //Console.WriteLine(isimler[0]); //Boşluk olur yukardakinden farklı

            List<string> isimler2 = new List<string> { "Burak", "Songül", "Kadriye", "Fatma" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]); //İlkeri yazdı.
            Console.WriteLine(isimler2[0]); //Burağı da yazdı.Yukarısı ile bağlantılı oldu.
        }
    }
}
