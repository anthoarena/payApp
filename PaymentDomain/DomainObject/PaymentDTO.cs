using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentDomain.DomainObject {

    public enum ProductType {
        PhysicalProduct = 1,
        Book = 2,
        Membership = 3,
        Video = 4
    }

    public class PaymentDTO {
        public int paymentId { get; set; }
        public int MemberId { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
    }
}
