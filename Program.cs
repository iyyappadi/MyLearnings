using Microsoft.VisualBasic;
using System.Data.Common;

namespace Pyramid;
class Program
{
    static void Main(string[] args)
    {

            int rows, number = 1, space, i, j;

        Console.Write("Enter the number of rows: ");
        rows = Convert.ToInt32 (Console.ReadLine());

        for (i = 1; i <= rows; i++)
        {
            for (space = 1; space <= (rows - i); space++)
            {
                Console.Write(" " +  "");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("{0} ", number);
                number++;
            }
            

            Console.WriteLine();
        }

        Console.ReadLine();

        
    }



}