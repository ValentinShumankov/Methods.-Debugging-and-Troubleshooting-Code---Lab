using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void Main( string [ ] args )
        {
            PrintingTriangle(int.Parse(Console.ReadLine( )));
        }

        private static void PrintingTriangle( int num )
        {
            for (int i = 1; i <= num; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine( );
            }
            for (int i = num; i >= 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine( );
            }
        }
    }
}
