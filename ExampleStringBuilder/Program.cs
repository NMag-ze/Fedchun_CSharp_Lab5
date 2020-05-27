using System;
using System.Text;//подключаем для доступа к StringBuilder'у


namespace ExampleStringBuilder
{
    class Program
    {
        static void TestStringBuilder()
        {
           
            StringBuilder str1 = new StringBuilder("Строка, сделанная с помощью StringBuilder");
            StringBuilder str2 = new StringBuilder("Строка, сделанная таким же образом");
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            str1.Replace("Строка", "string");//замена одной подстроки на другую подстроку
            str2.Append(" с помощью StringBuilder");//добавление подстроки в конце
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            str1.Insert(8, "sample text");//вставка подстроки после определенного элемента
            str2.Remove(5, 10);//удаление после индекса[5] 10 символов
            Console.WriteLine(str1);
            Console.WriteLine(str2);


        }
        static void Main(string[] args)
        {
            TestStringBuilder();

            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb.Append("Первое предложение,");
            sb.Insert(sb.Length, "второе предложение,");
            sb.Append("третье предложение,");
            sb.Insert(sb.Length, "четвертое предложение");
            Console.WriteLine(sb);
            Console.WriteLine();

            int num = 1;
            string [] pr = { "Предложение №1", "Предложение №2", "Предложение №3", "Предложение №4" };
            foreach (string predl in pr) sb2.AppendFormat("{0}:{1}, ", num++, predl);//форматированное присоединение
            Console.WriteLine(sb2);

            //Задания про буфер
            Console.WriteLine(sb.Capacity);//выводит текущий размер буфера
            Console.WriteLine(sb.MaxCapacity);//выводит максимальное значение буфера
            Console.WriteLine(sb2.Capacity);
            Console.WriteLine(sb2.MaxCapacity);
            sb.EnsureCapacity(2);
            sb2.EnsureCapacity(250);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb2.Capacity);
        }
    }
}
