using PaymentDomain.DomainObject;
using PaymentDomain.Interfaces;
using PaymentInfrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Products {
    public class BookProduct : Product {

        private readonly IShippingService _shippingService;
        private readonly IAgentService _agentService;

        public BookProduct(PaymentDTO payment, IShippingService shippingService, IAgentService agentService): base(payment) {
            _shippingService = shippingService;
            _agentService = agentService;
        }
        public override void ProcessPayments() {
            _shippingService.DuplicatePackingSlipForRoyalityDepartement();
            _agentService.GenerateCommisionPayment();
            base.ProcessPayments();
        }
    }
}
