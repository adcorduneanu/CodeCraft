namespace CraftCode
{
    public interface IPaymentGateway
    {
        void DoPayment(PaymentDetails paymentDetails);
    }
}