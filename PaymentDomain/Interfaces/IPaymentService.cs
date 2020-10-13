using PaymentDomain.DomainObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentDomain.Interfaces {
    public interface IPaymentService {
        IEnumerable<string> GetProductTypes();

        void ProcessPayment(PaymentDTO paymentDTO);
    }
}
