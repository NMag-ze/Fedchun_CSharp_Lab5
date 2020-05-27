using System;
using System.Text;

namespace ArrayOfStrings
{
    class Program
    {
        public static void SumInWords(int param)
        {
            StringBuilder temp = new StringBuilder(200);
            int first = param / 1000 - 1;
            int second = param / 100 % 10 - 1;
            int third = param / 10 % 10 - 1;
            int fourth = param % 10 - 1;
            int last = param % 100;

            string[] ar1 = {"один ", "два ",
                            "три", "четыре", "пять",
                            "шесть", "семь", "восемь",
                            "девять"};
            string[] ar2 = {"десять", "двадцать",
                            "тридцать", "сорок", "пятьдесят",
                            "шестьдесят", "семьдесят", "восемьдесят",
                            "девяносто"};
            string[] ar3 = {"сто", "двести",
                            "триста", "четыреста", "пятьсот",
                            "шестьсот", "семьсот", "восемьсот",
                            "девятьсот"};
            string[] ar4 = {"одна тысяча", "две тысячи",
                            "три тысячи", "четыре тысячи", "пять тысяч",
                            "шесть тысяч", "семь тысяч", "восемь тысяч",
                            "девять тысяч"};
            string[] ar5 = {"одиннадцать", "двенадцать",
                            "тринадцать", "четырнадцать", "пятнадцать",
                            "шестнадцать", "семнадцать", "восемнадцать",
                            "девятнадцать"};
            if (last > 10 && last < 20)
            {
                ar2 = ar5;
                third = last % 10 - 1;
                fourth = -1;
            }

            string res = temp.ToString();

            if (first >= 0) { res = ar4[first] + ' '; }
            if (second >= 0) { res += ar3[second] + ' '; }
            if (third >= 0) { res += ar2[third] + ' '; }
            if (fourth >= 0)
            {
                res += ar1[fourth] + ' ';
                switch (fourth)
                {
                    case 0:
                        res += "рубль";
                        break;
                    case 1:
                        res += "рубля";
                        break;
                    case 2:
                        res += "рубля";
                        break;
                    case 3:
                        res += "рубля";
                        break;
                    default:
                        res += "рублей";
                        break;
                }

            }
            else { res += "рублей"; }
            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            // второе задание
            SumInWords(9999);
        }
    }
}

