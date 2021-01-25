
using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(42, "Saliha Şahin");
            myDictionary.Add(56, "Mehmet Özdemir");
        }
    }
}