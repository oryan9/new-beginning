using System;

namespace new_beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            // value Type

            double number5 = 10.4; // 64bit
            decimal number6 = 10.4m;
            char character = 'A'; // sitring
            bool condition = false; // ture and false 
            byte number4 = 0; // 0 and 255 # 8bit
            short number3 = -32768; // -32768 and -32767 # 16bit
            int number1 = 10; // -2137483648 and 2137483647 (8 and 7) #32bit
            long number2 = 2137483648; // -9223372036854775808 and 9223372036854775807 #64bit
            var number7 = 10; 
            Console.WriteLine( "Number is 1: {0}" ,number1);
            Console.WriteLine("Number is 2: {0}", number2);
            Console.WriteLine("Number is 3: {0}", number3);
            Console.WriteLine("Number is 4: {0}", number4);
            Console.WriteLine("Number is 5: {0}", number5);
            Console.WriteLine("Character is: {0}", character);
            Console.WriteLine(Days.Friday);

       

        }
    }
    enum Days
    {
        Monday= 10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday
    }
}
