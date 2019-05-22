using PaymentsInformationAPI.Domain;

namespace PaymentsInformationAPI.Services.Interfaces
{
    public interface IMerchantDiscountRateService
    {
        MerchantDiscountRate GetAsync();
    }
}
