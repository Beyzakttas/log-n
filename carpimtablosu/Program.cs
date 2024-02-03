using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimtablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=10; i++)// 100
            {
                for(int j = 1; j <= 10; j++)//1000kere calisir
                {
                    Console.Write(i  +   "x"  + j+ "="  + ( i  *  j) );
                    Console.Write("     ");
                }
                Console.WriteLine("");
            }
            
            Console.ReadLine();
        }
    }
}
