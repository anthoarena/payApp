using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentDomain.Interfaces {
    public interface IShippingService {
        void GeneratePackingSlip();
        void AddFirstAidVideoToPackingSlip();
        void DuplicatePackingSlipForRoyalityDepartement();
    }
}
