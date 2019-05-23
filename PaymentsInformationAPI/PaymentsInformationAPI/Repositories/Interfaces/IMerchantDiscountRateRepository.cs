using PaymentsInformationAPI.Domain;
using System.Collections.Generic;

namespace PaymentsInformationAPI.Repositories.Interfaces
{
    public interface IMerchantDiscountRateRepository
    {
        IList<MerchantDiscountRate> Get();
        MerchantDiscountRate GetByAdquirente(string adquirente);
    }
}
