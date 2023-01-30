using System;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sum = Suma(5, 6);
            Console.WriteLine(sum);
            int[] numbers = { 34, 564, 23, 6, 722, 34 };
            var sumofarr = Sumb(numbers);
            Console.WriteLine(sumofarr);
            int[] numbersa = { 34, 564, 23, 6, 722, 34 };
            numbersz(numbersa);
            int[] numbersb = { 5435, 564, 22, 11, 3 };
            var arrays = array(numbersb);
            Console.WriteLine(arrays);
            var sumc = three(7, 8, 9);
            Console.WriteLine(sumc);
            var reverse = Reverse("Eleddin");
            Console.WriteLine(reverse);
            var digitsum = SumofDigits(203);
            Console.WriteLine(digitsum);


        }
        // - Verilmiş iki ədədi toplayıb qaytaran metod

        static int Suma(int a, int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }
        // - Verilmiş ədədlər siyahısındaki ədədlərini cəmini qaytaran metod

        static int Sumb(int[] numbers)
        {
            var sumb = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumb += numbers[i];
            }
            return sumb;

        }
        // - Verilmiş ədədlər siyahısındaki ədədlərin cəmini console-a yazdıran metod
        static void numbersz(int[] numbersz)
        {
            var sam = 0;
            for (int i = 0; i < numbersz.Length; i++)
            {
                sam += numbersz[i];


            }
            Console.WriteLine(sam);
        }

        // - Verilmiş ədədlər siyahısındaki ən böyük ədədi qaytaran metod
        static int array(int[] numsa)
        {
            var max = numsa[0];
            for (int i = 0; i < numsa.Length; i++)
                if (numsa[i] > max)
                {

                    max = numsa[i];
                }
            return max;
        }

        // - Verilmiş 3 ədəddən ən böyüyünü tapan proqram
        static int three(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b > c)
                return b;
            else
                return c;
        }
        // - Verilmiş yazını əks şəkildə qaytaran metod
        static string Reverse(string str)
        {
            string newStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
        // - Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int SumofDigits(int n)
        {

            int sume = 0;
            while (n > 0)
            {
                sume += n % 10;
                n /= 10;
            }
            return sume;
        }
    }
}
 