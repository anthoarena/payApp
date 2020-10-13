using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInfrastructure.Model {
    public class Member {

        public int MemberId { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public int MembershipId { get; set; }
    }
}
