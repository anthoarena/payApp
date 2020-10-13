using PaymentDomain.DomainObject;
using PaymentDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Services {
    public class PaymentService : IPaymentService {
       
        // Return the Product type ordered 
        public IEnumerable<string> GetProductTypes() {
            return new string []{ "Book", "Video", "PysicalProduct", "Membership" };
        }

        public void ProcessPayment(PaymentDTO paymentDTO) {
            switch (paymentDTO.ProductType) {
                case ProductType.Book:             
                    break;
                case ProductType.Membership:
                    break;
                case ProductType.Video:
                    break;
                case ProductType.PhysicalProduct:
                    break;
            }
        }
    }
}
