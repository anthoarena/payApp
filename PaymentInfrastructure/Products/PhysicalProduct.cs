using PaymentDomain.DomainObject;
using PaymentDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Products {
    public class PhysicalProduct : Product {

        private readonly IShippingService _shippingService;
        private readonly IAgentService _agentService;

        public PhysicalProduct(PaymentDTO paymentDto, IShippingService shippingService, IAgentService agentService) : base(paymentDto) {
            _shippingService = shippingService;
            _agentService = agentService;
        }
        public override void ProcessPayments() {
            _shippingService.GeneratePackingSlip();
            _agentService.GenerateCommisionPayment();
            base.ProcessPayments();
        }
    }
}
