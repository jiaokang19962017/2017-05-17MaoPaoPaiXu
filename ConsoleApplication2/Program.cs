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
            Season season = (Season)flag;//将数值类型转化为枚举类型
            switch (season)
            {
                case Season.spring:
                    Console.WriteLine("春天");
                    break;
                case Season.summer:
                    Console.WriteLine("夏天");
                    break;
                case Season.autume:
                    Console.WriteLine("秋天");
                    break;
                case Season.winter:
                    Console.WriteLine("冬天");
                    break;
            }
        }
    }
}
