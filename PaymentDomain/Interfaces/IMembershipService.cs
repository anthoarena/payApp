using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentDomain.Interfaces {
    public interface IMembershipService {
        void ActivateMembership(int memberId);
        void UpgradeMembership(int memberId);
    }
}
