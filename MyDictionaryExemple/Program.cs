using System;
using System.Collections.Generic;

namespace MyDictionaryExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Deniz");
            foreach (var item in myDictionary.value)
            {
                Console.WriteLine(item);
            }

            //foreach (KeyValuePair<int, string> kvp in myDictionary)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}
        }
    }
}
