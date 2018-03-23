using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAction aa2 = new AsyncAction();
            aa2.CallbackAsyncDelete();
            Console.ReadKey();
        }
    }
}
