using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    enum color { yellow, blue, green, blac, red };
    enum Season {spring,summer=10,autume,winter }
    class Program
    {
        static void Main(string[] args)
        {
            //枚举是一种固定的集合
            // enum Weekday { Sun,Mon,Tue,Wed,Thu,Fri,Sat};

            //   Console.WriteLine("yellow={0}",(int)color.yellow);
            int flag = Convert.ToInt32(Console.ReadLine());
            switch (flag)
            {
                case 0:
                    Console.WriteLine((int)Season.spring);
                    break;
                case 1:
                    Console.WriteLine((int)Season.summer);
                    break;
                case 2:
                    Console.WriteLine((int)Season.autume);
                    break;
                case 3:
                    Console.WriteLine((int)Season.winter);
                    break;
            }
        }
    }
}
