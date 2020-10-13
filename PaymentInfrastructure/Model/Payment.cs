using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Model {
    public class Payment {
        public int PaymentId { get; set; }
        public int MemberId { get; set; }
        public int ProductType { get; set; }
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
    }
}
