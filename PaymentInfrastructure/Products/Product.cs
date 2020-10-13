using PaymentDomain.DomainObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Products {
    public abstract class Product {
        private readonly PaymentDTO _paymentDto;

        protected Product(PaymentDTO paymentDto) {
            _paymentDto = paymentDto;
        }

        public PaymentDTO PaymentDetails => _paymentDto;

        public virtual void ProcessPayments() { }
    }
}