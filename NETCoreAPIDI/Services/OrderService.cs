using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreAPIDI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IPaymentService paymentService;

        public OrderService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public string CreateOrder()
        {
            return this.paymentService.PayCreditCard();
        }
    }
}
