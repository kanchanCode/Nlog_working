using System;

namespace classwork_Nlog
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            nlog nlogObject = new nlog();
            nlogObject.LogDebug("Debugging the code");

            addNum obj2 = new addNum();
            obj2.sum(0, 0);
        }
    }
}
