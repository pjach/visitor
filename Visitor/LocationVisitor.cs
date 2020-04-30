using System;
using System.Threading;

namespace Visitor
{
    public class LocationVisitor : IVisitor
    {
        private readonly double _latitude;
        private readonly double _longitude;

        public LocationVisitor(double latitude, double longitude)
        {
            this._latitude = latitude;
            this._longitude = longitude;
        }

        public void VisitMobilePhoneCall(Phone phone, string number)
        {
            phone.Call(number);
            Console.WriteLine("Location: latitude: " + _latitude.ToString() + " longitude: " + _longitude.ToString());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public void VisitMobilePhoneTextMessage(Phone phone, string number, string text)
        {
            phone.TextMessage(number, text);
            Console.WriteLine("Location: latitude: " + _latitude.ToString() + " longitude: " + _longitude.ToString());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public double GetLatitude()
        {
            return _latitude;
        }

        public double GetLongitude()
        {
            return _longitude;
        }
    }
}