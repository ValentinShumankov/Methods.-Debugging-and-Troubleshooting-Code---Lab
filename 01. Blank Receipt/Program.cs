using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void Main( string [ ] args )
        {
            PrintReceipt( );
        }
        static void PrintReceipt()
        {
            PrintHeader( );
            PrintBody( );
            PrintFooter( );
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to" + new string('_', 30 - "Charged to".Length));
            Console.WriteLine("Received by" + new string('_', 30 - "Received by".Length));
        }
        static void PrintFooter()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("© SoftUni");
        }
    }
}
