using PaymentsInformationAPI.Domain;
using System.Collections.Generic;

namespace PaymentsInformationAPI.Services.Interfaces
{
    public interface IMerchantDiscountRateService
    {
        IList<MerchantDiscountRate> Get();
    }
}
