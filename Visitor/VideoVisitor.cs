using System;
using System.Threading;

namespace Visitor
{
    public class VideoVisitor : IVisitor
    {
        private readonly string _video;

        public VideoVisitor(string video)
        {
            this._video = video;
        }

        public void VisitMobilePhoneCall(Phone phone, string number)
        {
            phone.Call(number);
            Console.WriteLine("Adding video: " + _video);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public void VisitMobilePhoneTextMessage(Phone phone, string number, string text)
        {
            phone.TextMessage(number, text);
            Console.WriteLine("Adding image: " + _video);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public string TakeSnapshotDuringVideoCall()
        {
            Random random = new Random();
            return Convert.ToString(random.Next(100, 999), 2).PadLeft(10, '0');
        }
    }
}