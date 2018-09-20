using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
//1st
            //a
            Int16 theFirst = -30_000;
            Int32 theSecond = 100_000 + theFirst;
            long theThird = 9_999_999;
            byte theForth = 200;
            ushort theFifth = 60_000;
            char theSixth = 'Y';
            bool theSeventh = false;
            float theEighth = 14.6989786786f;
            double theNinth = 0.3758932758927D;
            decimal theTenth = 4.99944563463M;
            string theEleventh = "Yulia";
            object theTwelfth = "Polinskaya";
            Console.WriteLine("Work 1 \n (a): " + theFirst + "; " + theSecond + "; " + theThird + "; " + theForth + "; " + theFifth + "; " + theSixth + "; " + theSeventh + "; " + theEighth + "; " + theNinth + "; " + theTenth + "; " + theEleventh + "; " + theTwelfth);

            //b

            Int32 one = theFirst + 10_000;
            decimal two = theForth + 100;
            long three = theFirst * 100;
            object foure = theSixth + "ulia";
            object five = theForth - 201;
            Console.WriteLine("(b1): " + one + "; " + two + "; " + three + "; " + foure + "; " + five);

            Int16 one1 = (Int16)theSecond;
            float two1 = (float)theTenth;
            Int16 three1 = (Int16)theThird;
            float foure1 = (float)theNinth;
            double five1 = (double)theTenth;
            Console.WriteLine("(b2): " + one1 + "; " + two1 + "; " + three1 + "; " + foure1 + "; " + five1);

            //c
            object one2 = theFirst;
            object two2 = theSecond;
            short three2 = (short)one2;

            //d
            var oneD = "Yulia";
            Console.WriteLine(oneD.GetType());

            //e
            int? theFirstE = null;
            int theSecondE = theFirstE ?? 9;
            Console.WriteLine("(e): " + (theFirstE ?? theSecondE));

            //2
            //a
            string one3 = "Polinskaya";
            string two3 = "Yulia";
            int comp = String.Compare(one3, two3);
            if (comp < 0)
                Console.WriteLine("первая строка перед второй в алфавите");
            else
                Console.WriteLine("вторая строка перед первой в алфавите");
            //b
            string oneB = "abc";
            string twoB = "def";
            string threeB = "ghi";
            string concat = String.Concat(oneB, twoB, threeB);
            string copy = String.Copy(threeB);
            string sub = oneB.Substring(1, 2);
            string[] split = twoB.Split(new char[] { ',' });
            string splt = null;
            foreach (var temp in split)
            {
                splt += temp;
            }
            string insert = oneB.Insert(2, "-");
            string remove = twoB.Remove(2, 1);
            Console.WriteLine(" Сцепление: " + concat + "\n" + " Копирование: " + copy + "\n" + " Выделение подстроки: " + sub + "\n" + " Разделение строки: " + splt + "\n Вставка подстроки в заданную позицию: " + insert + "\n Удаление подстроки: " + remove);
            //с
            string oneC = "";
            string twoC = null;
            string threeC = "Yulia";
            Console.WriteLine("\0" + String.Concat(threeC, twoC) + ";" + String.Concat(oneC, twoC) + ";" + String.Concat(oneC, twoC).Length);
            //d
            StringBuilder hip = new StringBuilder("LOVE", 10);
            hip.Append(new char[] { 'i', 's', 'M', 'A', 'D', 'N', 'E', 'S', 'S' });
            Console.WriteLine("\0" + hip);
            hip.Insert(0, "OUR_");
            Console.WriteLine("\0" + hip);
            hip.Remove(0, 3);
            Console.WriteLine("\0" + hip);
            hip.Insert(5, "_");
            hip.Insert(8, "_");
            Console.WriteLine("\0" + hip);
        }
    }
}
