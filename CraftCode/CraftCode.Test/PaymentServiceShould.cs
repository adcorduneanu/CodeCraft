using System;
using Moq;
using NUnit.Framework;

namespace CraftCode.Day1.Test
{
    class PaymentServiceShould
    {
        private PaymentService _paymentService;
        private User _user;
        private PaymentDetails _paymentDetails;
        private Mock<IUserValidator> _userValidator;
        private Mock<IPaymentGateway> _paymentGateway;

        [SetUp]
        public void Initialize()
        {
            this._userValidator = new Mock<IUserValidator>();
            this._paymentGateway = new Mock<IPaymentGateway>();

            this._paymentService = new PaymentService(this._userValidator.Object, this._paymentGateway.Object);

            this._user = new User();
            this._paymentDetails = new PaymentDetails();
        }

        [Test]
        public void Throw_And_Exception_When_The_User_Is_Invalid()
        {
            this._userValidator.Setup(x => x.IsValid(_user)).Returns(false);

            Assert.Throws<Exception>(() => this._paymentService.ProcessPayment(this._user, this._paymentDetails));
        }

        [Test]
        public void Not_Invoke_Payment_Gateway_If_The_User_Is_Invalid()
        {
            this._userValidator.Setup(x => x.IsValid(_user)).Returns(false);

            Assert.Throws<Exception>(() => this._paymentService.ProcessPayment(this._user, this._paymentDetails));

            this._paymentGateway.Verify(x => x.DoPayment(_paymentDetails), Times.Never);
        }

        [Test]
        public void Call_The_Payment_Gateway_If_The_User_Is_Valid()
        {
            this._userValidator.Setup(x => x.IsValid(_user)).Returns(true);
            this._paymentGateway.Setup(x=>x.DoPayment(_paymentDetails));

            this._paymentService.ProcessPayment(_user, _paymentDetails);

            this._userValidator.Verify(x=>x.IsValid(_user));
            this._paymentGateway.Verify(x=>x.DoPayment(_paymentDetails));
        }
    }
}
