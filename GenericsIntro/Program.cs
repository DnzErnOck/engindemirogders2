﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList <string> isimler= new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Lenght);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Lenght);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
