using System;

namespace Console_.NET
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.ReadKey();

            byte b; // 0 to 255
            sbyte sb; // -128 to 127
            short sh; // - 32768 to 327677
            ushort us; // 0 to 65535
            int i; // - 21477483648 to 214774836477
            uint ui = uint.MaxValue; // 0 to 4294967295U
            long ln; //
            ulong ul; //

            // float numbers
            float f1 = 5.7f; // 7  numbers after ,
            double db; //15  numbers after ,

            //Sibol
            char ch = '!';

            string str = "Hey, haw are you ?";

            bool bl = true;
        }
    }
}