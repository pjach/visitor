using System;

namespace Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Phone phone = new MobilePhone("864583187", "Galaxy S8");
            Phone smartphone = new SmartPhone("865923423", "Galaxy s9", "Android");
            phone.Call("869845109");
            Console.WriteLine(Environment.NewLine);
            IVisitor visitorA = new VideoVisitor("010101010101110101");
            phone.AcceptVisitorCall(visitorA, "864987298");
            Console.WriteLine(Environment.NewLine);
            smartphone.AcceptVisitorCall(visitorA, "865934534");
            Console.ReadKey();
        }
    }
}