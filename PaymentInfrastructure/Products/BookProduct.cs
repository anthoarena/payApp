﻿using PaymentDomain.DomainObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Products {
    public class BookProduct : Product {

        public BookProduct(PaymentDTO payment): base(payment) {
        }
        public override void ProcessPayments() {
            base.ProcessPayments();
        }
    }
}
