using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreAPIDI.Services
{
    public class PaymentService : IPaymentService
    {
        public string PayCreditCard()
        {
            return "PaymentService.PayCreditCard()";
        }
    }
}
