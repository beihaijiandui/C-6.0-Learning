using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncInvoke
{
    public class AsyncAction
    {
        public delegate int AsyncInvoke();

        public class TestAsyncInvoke
        {
            public static int Method1()
            {
                Console.WriteLine($"Invoked Method1 on Thread {Thread.CurrentThread.ManagedThreadId}");
                return (1);
            }
        }

        public void CallbackAsyncDelete()
        {
            //回调委托
            AsyncCallback callBack = DelegateCallback;
            //自定义委托
            AsyncInvoke method1 = TestAsyncInvoke.Method1;
            Console.WriteLine($"Calling BeginInvike on Thread {Thread.CurrentThread.ManagedThreadId}");
            IAsyncResult asyncResult=method1.BeginInvoke(callBack, method1);//以BeginInvoke开始,第二个参数表示状态对象 
            return;
        }

        private static void DelegateCallback(IAsyncResult iresult)
        {
            Console.WriteLine($"Getting callback on Thread {Thread.CurrentThread.ManagedThreadId}");
            AsyncResult asyncResult = (AsyncResult)iresult;
            AsyncInvoke method1 = (AsyncInvoke)asyncResult.AsyncDelegate;

            int retVal = method1.EndInvoke(asyncResult);//在回调委托里面EndInvoke
            Console.WriteLine($"retVal (CallBack):{retVal}");
        }
    }
}
