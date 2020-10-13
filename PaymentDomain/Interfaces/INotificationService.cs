using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentDomain.Interfaces {
    public interface INotificationService {
        void SendMembershipActivationEmail(int memberId); 
        void SendUpgradeMembershipEmail(int memberId);
    }
}
