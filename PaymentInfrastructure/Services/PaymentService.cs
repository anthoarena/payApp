using PaymentDomain.DomainObject;
using PaymentDomain.Interfaces;
using PaymentInfrastructure.Model;
using PaymentInfrastructure.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Services {
    public class PaymentService : IPaymentService {

        private readonly PaymentContext _db;

        private readonly IShippingService shippingService = new ShippingService();
        private readonly IAgentService agentService = new AgentService();

        public PaymentService(PaymentContext db) {
            _db = db;

        }


        // Return the Product type ordered 
        public IEnumerable<string> GetProductTypes() {
            return new string []{ "Book", "Video", "PysicalProduct", "Membership" };
        }

        // Process all ProductType payments
        public void ProcessPayment(PaymentDTO paymentDto) {
            switch (paymentDto.ProductType) {
                case ProductType.Book:
                    BookProduct book = new BookProduct(paymentDto);
                    book.ProcessPayments();
                    break;
                case ProductType.Membership:
                    MembershipProduct membership = new MembershipProduct(paymentDto);
                    membership.ProcessPayments();
                    break;
                case ProductType.Video:
                    VideoProduct video = new VideoProduct(paymentDto);
                    video.ProcessPayments();
                    break;
                case ProductType.PhysicalProduct:
                    PhysicalProduct physicalProduct = new PhysicalProduct(paymentDto, shippingService, agentService);
                    physicalProduct.ProcessPayments();
                    break;
            }
        }
    }
}
