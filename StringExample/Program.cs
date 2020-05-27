using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Строка 1";
            string str2 = new string('s', 5);
            char[] chararray = { 't', 'e', 's', 't' };
            string str3 = new string(chararray);

            //присваивание
            Console.WriteLine(str1);
            str1 = str2;
            Console.WriteLine(str1);
            //эквивалентность
            if (str1 == str2) Console.WriteLine("Одинаковы");
            if (str2 != str3) Console.WriteLine("Не одинаковы");
            //конкатенация
            str1 = str2 + " " + str3;
            Console.WriteLine(str1);
            //индексация
            Console.WriteLine(str1[6]);
            //задача на индексацию №1
            int i = 0;
            string comment = "Это /*Комментарий*/ а вот /*еще один*/";
            string res = "";

            while (i < comment.Length - 1)
            {
                if (comment[i] == '/' && comment[i + 1] == '*')
                {
                    i += 2;

                    while (!(comment[i] == '*' && comment[i + 1] == '/'))
                    {
                        res += comment[i];
                        i++;
                    }
                }
                else
                {
                    i++;
                }

            }
            Console.WriteLine(res);
            //задача на индексацию №2
            i = 0;
            string aa = ";alkstudkfpstudentkdaokdgpstudentdjaldj210d-09@";
            string res2 = "";
            while(i<aa.Length-1)
            {
                if(!(aa[i]=='s'&&aa[i+1]=='t'&&aa[i+2]=='u'&&aa[i+3]=='d'&&aa[i+4]=='e'&&aa[i+5]=='n'&&aa[i+6]=='t'))
                {
                    res2 += aa[i]; i++;
                }
                else { i += 7; }
            }
            Console.WriteLine(res2);
        }
    }
}
