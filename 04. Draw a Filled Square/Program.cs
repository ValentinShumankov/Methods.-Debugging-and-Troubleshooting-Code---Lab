using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main( string [ ] args )
        {
            DrowFilledSquare(int.Parse(Console.ReadLine()));
        }

        private static void DrowFilledSquare( int size )
        {
            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(new string('-', size * 2));
                }
                else if (i == (size - 1))
                {
                    Console.WriteLine(new string('-', size * 2));
                }
                else
                {
                    for (int k = 0; k <= size; k++)
                    {
                        if (k == 0)
                        {
                            Console.Write("-");
                        }
                        else if(k == (size))
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(@"\/");
                        }
                    }
                    Console.WriteLine();
                }

            }

        }
    }
}
