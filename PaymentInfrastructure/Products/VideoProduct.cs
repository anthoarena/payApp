using PaymentDomain.DomainObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Products {
    public class VideoProduct : Product{

        public VideoProduct(PaymentDTO payment) : base(payment) {
        }
        public override void ProcessPayments() {
            base.ProcessPayments();
        }
    }
}
