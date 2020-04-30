using System;

namespace Visitor
{
    public class MobilePhone : Phone
    {
        public MobilePhone(string number, string model) : base(number, model)
        {
        }

        public override void AcceptVisitorCall(IVisitor visitor, string number)
        {
            visitor.VisitMobilePhoneCall(this, number);
        }

        public override void AcceptVisitorTextMessage(IVisitor visitor, string number, string text)
        {
            visitor.VisitMobilePhoneTextMessage(this, number, text);
        }

        public void TurnOnRadio()
        {
            Console.WriteLine("Radio is on");
        }
    }
}