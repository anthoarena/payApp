using PaymentDomain.Interfaces;
using PaymentInfrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Services {
    public class MembershipService : IMembershipService {

      

        public MembershipService() {
   
        }

        public void ActivateMembership(int memberId) {
            throw new NotImplementedException();
        }

        public void UpgradeMembership(int memberId) {
            throw new NotImplementedException();
        }
    }
}
