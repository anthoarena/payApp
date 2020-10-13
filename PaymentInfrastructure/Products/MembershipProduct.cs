using PaymentDomain.DomainObject;
using PaymentDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Products {
    public class MembershipProduct : Product {
        private readonly IMembershipService _membershipService;
        private readonly INotificationService _notificationService;

        public MembershipProduct(PaymentDTO paymentDto, IMembershipService membershipService, INotificationService notificationService)
            : base(paymentDto) {
            _membershipService = membershipService;
            _notificationService = notificationService;
        }

        public override void ProcessPayments() {
         

          

            base.ProcessPayments();
        }
    }
}
