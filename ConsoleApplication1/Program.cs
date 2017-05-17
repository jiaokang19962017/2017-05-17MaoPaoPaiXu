using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10] { 20, 5, 17, 28, 19, 15, 29, 87, 65, 32 };
            int temp;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length-1; j++)
                {
                    if (number[j] < number[i])
                    {
                        temp = number[j];
                        number[j] = number[j+1];
                        number[j+1] = temp;
                    }
                    
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

          /*  for (int i = 1; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length - i; j++)
                {
                    if (number[j] < number[j] + 1)
                    {
                        int temp;
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j+1] = temp;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]+" ");
            }*/
        }
    }
}
