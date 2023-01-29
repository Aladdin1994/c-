using System;

namespace bazar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region // Verilmiş ədədin rəqəmləri cəmini tapan proqram

            Console.WriteLine("Ededi daxil et");
            var input = Console.ReadLine();
            int N = Convert.ToInt32(input);

            var sum = 0;

            while (N > 0)
            {
                sum += N % 10;
                N = (N - N % 10) / 10;
            }
            Console.WriteLine(sum);
            #endregion

            //verilmiş ədədlər siyahısındaki 21-ə bölenən ədədlərin ədədi ortasını tapan proqram
            var sum1 = 0;
            int count = 0;

            int[] number = { 25, 45, 8, 78, 21, 99, 2, 45, 6, 42 };
            for (int i = 0; i < number.Length; i++)
            {

                if (number[i] % 21 == 0)
                {
                    sum1 += number[i];
                    count++;

                }


            }
            Console.WriteLine(sum1 /= count);


            // - Verilmiş qiymət dəyəri 64-dən böyük olarasa console-da "məzun oldunuz", əks halda
            // "məzun olmadınız" yazdırsan proqram. Qiymət dəyərini console-dan qəbul edin (Readline ilə).Q
            // iymət dəyəri 0-100 aralığında olmalıdır, 0-dan kiçin və ya 100-dən böyük dəyər daxil edələrsə
            // yenidən daxil edilməsi istənilsin proqram tərəfindən.



            string number2;
            int point;
            do
            {
                Console.WriteLine("toplanan bal");
                number2 = Console.ReadLine();
                point = Convert.ToInt32(number2);

            }
            while (point <= 0 || point >= 100);


                if (point > 64)
                {
                    Console.WriteLine("mezun oldunuz");

                }
                else
                {
                    Console.WriteLine("mezun olmadiniz");
                }
            




        }
    }
}
