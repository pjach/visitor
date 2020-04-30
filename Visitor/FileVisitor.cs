using System;
using System.Threading;

namespace Visitor
{
    public class FileVisitor : IVisitor
    {
        private readonly string _file;

        public FileVisitor(string fileName, string fileType)
        {
            _file = fileName + "." + fileType;
        }

        public void VisitMobilePhoneCall(Phone phone, string number)
        {
            phone.Call(number);
            Console.WriteLine("Sending file: " + _file);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public void VisitMobilePhoneTextMessage(Phone phone, string number, string text)
        {
            phone.TextMessage(number, text);
            Console.WriteLine("Sending file: " + _file);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public void OpenFile(string fileName, string fileType)
        {
            Console.WriteLine("Opening file: " + fileName + "." + fileType);
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Convert.ToString(random.Next(1000, 9999), 2).PadLeft(15, '0'));
            }
        }
    }
}