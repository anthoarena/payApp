using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentDomain.DomainObject {
    public class MemberDTO {
        public int MemberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int MembershipId { get; set; }
    }
}
