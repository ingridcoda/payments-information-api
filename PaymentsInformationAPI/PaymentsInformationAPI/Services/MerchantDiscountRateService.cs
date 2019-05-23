using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using PaymentsInformationAPI.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PaymentsInformationAPI.Services
{
    public class MerchantDiscountRateService : IMerchantDiscountRateService
    {
        private readonly IMerchantDiscountRateRepository MerchantDiscountRateRepository;

        public MerchantDiscountRateService(IMerchantDiscountRateRepository merchantDiscountRateRepository)
        {
            MerchantDiscountRateRepository = merchantDiscountRateRepository;
        }

        public IList<MerchantDiscountRate> Get()
        {
            try
            {
                var mdr = MerchantDiscountRateRepository.Get();
                return mdr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
