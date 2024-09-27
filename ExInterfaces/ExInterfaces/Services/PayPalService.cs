using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterfaces.Services
{
    class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount += 0.02;
        }
        public double Interest(double amount, int months)
        {
            for (int i = 0; i < months; i++)
            {
                amount += 0.01 * i;
            }
            return amount;
        }
    }
}
