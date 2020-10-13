using PaymentDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Services {
    public class NotificationService : INotificationService {
        public void SendMembershipActivationEmail(int memberId) {
            throw new NotImplementedException();
        }

        public void SendUpgradeMembershipEmail(int memberId) {
            throw new NotImplementedException();
        }
    }
}
