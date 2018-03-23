using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedSizeCollection C = new FixedSizeCollection(5);
            Console.WriteLine(C);
            string s1 = "s1";
            string s2 = "s2";
            string s3 = "s3";
            int i1 = 1;

            C.AddItem(s1);
            C.AddItem(s2);
            C.AddItem(s3);
            C.AddItem(i1);
            Console.ReadKey();

            FixedSizeCollection<string> GC = new FixedSizeCollection<string>(5);
            Console.WriteLine(C);
            string gs1 = "s1";
            string gs2 = "s2";
            string gs3 = "s3";
            int gi1 = 1;

            GC.AddItem(gs1);
            GC.AddItem(gs2);
            GC.AddItem(gs3);
            GC.AddItem(gi1);
            Console.ReadKey();
        }
    }
}
