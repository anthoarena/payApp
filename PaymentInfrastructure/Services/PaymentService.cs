using PaymentDomain.DomainObject;
using PaymentDomain.Interfaces;
using PaymentInfrastructure.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Services {
    public class PaymentService : IPaymentService {

        private readonly IShippingService shippingService = new ShippingService();
        private readonly IAgentService agentService = new AgentService();

        public PaymentService() { }


        // Return the Product type ordered 
        public IEnumerable<string> GetProductTypes() {
            return new string []{ "Book", "Video", "PysicalProduct", "Membership" };
        }

        // Process all ProductType payments
        public void ProcessPayment(PaymentDTO paymentDto) {
            switch (paymentDto.ProductType) {
                case ProductType.Book:             
                    break;
                case ProductType.Membership:
                    break;
                case ProductType.Video:
                    break;
                case ProductType.PhysicalProduct:
                    PhysicalProduct physicalProduct = new PhysicalProduct(paymentDto, shippingService, agentService);
                    physicalProduct.ProcessPayments();
                    break;
            }
        }
    }
}
