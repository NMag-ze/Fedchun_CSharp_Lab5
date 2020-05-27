using System;

namespace SplitJoin
{
    class Program
    {
        static void SplitAndJoin (string txt)
        {
            string[] SimpleSentences, Words;
            SimpleSentences = txt.Split(',');
            Words = txt.Split(' ');
            foreach(string s in SimpleSentences) Console.WriteLine(s);
            Console.WriteLine();
            foreach(string s2 in Words) Console.WriteLine(s2);
            Console.WriteLine();
            string predlozh = String.Join(' ',Words);
            Console.WriteLine(predlozh);
            
        }

        static void Main(string[] args)
        {
            string text = "У попа была собака, он её любил.";
            SplitAndJoin(text);

        }
    }
}
