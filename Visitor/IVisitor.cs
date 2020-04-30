namespace Visitor
{
    public interface IVisitor
    {
        void VisitMobilePhoneCall(Phone phone, string number);

        void VisitMobilePhoneTextMessage(Phone phone, string number, string text);
    }
}