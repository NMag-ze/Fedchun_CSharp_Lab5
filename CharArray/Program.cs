using System;
using System.Text;

namespace CharArray
{
    class Program
    {
        static void PrintCharAr(char[] mas) //печать массива символов
        {
            foreach (char c in mas) Console.Write(c);
            Console.WriteLine();
        }

        static string CharArrayToString(char[] mas) //преобразование массива символов в строку
        {
            string stroka = new string(mas);
            return stroka;
        }

        static int IndexOfStr(char[] s1, char[] s2)
        {
            string strchar1 = new string(s1);
            string strchar2 = new string(s2);
            int ind = strchar1.IndexOf(strchar2);

            return ind;
        }

        static void TestIndexSym(char[] s1,string s,char ch)//нахождение всех индексов вхождения подстроки и символа в строку
        {
           
            
            string str = new string(s1);
            int index=0;
            Console.WriteLine("Индексы вхождения строки <<" + s + ">>:"); ;
            while ((index = str.IndexOf(s, index)) != -1)
            {
                Console.Write(index+" ");
                index += s.Length;
            }
            Console.WriteLine();
            index = 0;
            Console.WriteLine("Индексы вхождения символа <<" + ch + ">>:"); ;
            while ((index = str.IndexOf(ch, index)) != -1)
            {
                Console.Write(index + " ");
                index ++;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //char[] str1 = "Hello, World!";  ошибка так нельзя инициализировать массив символов
            char[] str1 = { 'H','e','l','l','o',',','W','o','r','l','d','!' };
            string str2 = "Здравствуй, Мир!";
            PrintCharAr(str1);
            string str3 = CharArrayToString(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            char[] str4 = {'e','l','l'};
            Console.WriteLine(IndexOfStr(str1, str4));
            TestIndexSym(str1,"Wor",'l');

        }
    }
}
