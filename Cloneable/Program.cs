using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("浅拷贝：");
            ShallowClone sc = new ShallowClone();
            ShallowClone sc2 = sc.ShallowCopy();
            Console.WriteLine(sc.str);
            Console.WriteLine(sc2.str);
            sc.str = "123";
            Console.WriteLine(sc.str);
            Console.WriteLine(sc2.str);

            Console.WriteLine("深拷贝：");
            DeepClone dc = new DeepClone();
            DeepClone dc2 = dc.DeepCopy();
            Console.WriteLine(dc.str);
            Console.WriteLine(dc2.str);
            dc.str = "123";
            Console.WriteLine(dc.str);
            Console.WriteLine(dc2.str);
            Console.ReadKey();
        }
    }
}
