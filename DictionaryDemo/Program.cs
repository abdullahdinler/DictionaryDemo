using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Plaka = new MyDictionary<int, string>();
            Plaka.Add(21, "Diyarbakir");
        }
    }
}
