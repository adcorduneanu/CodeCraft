using System;

namespace CraftCode.Day1
{
    public class PaymentService
    {
        private readonly IUserValidator _userValidator;
        private readonly IPaymentGateway _paymentGateway;

        public PaymentService(IUserValidator userValidator, IPaymentGateway paymentGateway)
        {
            _userValidator = userValidator;
            _paymentGateway = paymentGateway;
        }

        public void ProcessPayment(User user, PaymentDetails paymentDetails)
        {
           if (!this._userValidator.IsValid(user))
               throw new Exception("Invalid user");

           _paymentGateway.DoPayment(paymentDetails);
        }
    }
}
