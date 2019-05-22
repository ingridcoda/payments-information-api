using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using System.Collections.Generic;

namespace PaymentsInformationAPI.Repositories
{
    public class MerchantDiscountRateRepository : IMerchantDiscountRateRepository
    {
        public MerchantDiscountRate Get()
        {
            return new MerchantDiscountRate()
            {
                Adquirente = "Adquirente A",
                Taxas = new List<Tax>()
                {
                    new Tax()
                    {
                        Bandeira = Bandeira.Visa,
                        Credito = new decimal(2.25),
                        Debito = new decimal(2.00)
                    },
                    new Tax()
                    {
                        Bandeira = Bandeira.Mastercard,
                        Credito = new decimal(2.35),
                        Debito = new decimal(1.98)
                    }
                }
            };
        }
    }
}
