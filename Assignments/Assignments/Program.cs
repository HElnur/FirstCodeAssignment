using System;

namespace Assignjments
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment-1
            //int[] numbers = { 13, 45, 89, 102, 39, 678, 934, 1000 , 10 , 123 , 175 , 18 };
            //var counter = 0;

            //for (var i = 0; i<numbers.Length; i++)
            //{
            //    var num = numbers[i];
            //    var sum = 0;

            //    while (num > 0)
            //    {
            //        var digit = num % 10;
            //        sum += digit;

            //        num = (num - digit) / 10;
            //    }

            //    if (sum < 10)
            //    {
            //        counter++;

            //    }
            //}
            //Console.WriteLine(counter);

            //****************************************************************************************

            //Assignment-2

            //int counter = 0;

            //for(var i = 1; i<8000;i++)
            //{
            //    var num = i;

            //    if (num % 2 == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);

            //****************************************************************************************

            //Assignment-3
       
            Console.WriteLine("Number => ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Bu ededin koku yoxdur!");
            }

            else
            {
                for (var i = 0; i < number; i++)
                {
                    if (i * i <= number)
                    {
                        continue;
                    }

                    else
                    {
                        Console.WriteLine(i - 1);
                        break;
                    }
                }
            }

            

        }
    }
}
