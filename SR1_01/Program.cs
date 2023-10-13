using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_01
{
    internal class Program
    {
       static void Main(string[] args)
        {
            //Dogクラスのインスタンスhachiを生成する
            Dog hachi = new Dog();
            hachi.Bark();

            //Dogクラスのインスタンスpochiを生成する
            Dog poshi = new Dog();
            poshi.Bark();
            poshi.Run();

            //一時停止
            Console.ReadLine();
        }
    }
}
