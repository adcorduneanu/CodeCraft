namespace CraftCode.Day1
{
    public interface IPaymentGateway
    {
        void DoPayment(PaymentDetails paymentDetails);
    }
}