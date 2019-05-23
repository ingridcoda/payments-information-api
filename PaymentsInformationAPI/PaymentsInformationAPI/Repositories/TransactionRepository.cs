using Microsoft.Extensions.Configuration;
using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using System;
using System.Linq;

namespace PaymentsInformationAPI.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IConfiguration configuration;
        private readonly IMerchantDiscountRateRepository MerchantDiscountRepository;

        public TransactionRepository(IConfiguration _configuration, IMerchantDiscountRateRepository merchantDiscountRepository)
        {
            configuration = _configuration;
            MerchantDiscountRepository = merchantDiscountRepository;
        }

        public TransactionResponse Create(TransactionRequest newTransaction)
        {
            try
            {
                var mdr = MerchantDiscountRepository.GetByAdquirente(newTransaction.Adquirente.ToLower());
                if (mdr == null) return null;

                var taxa = mdr.Taxas.First(t => t.Bandeira.ToString().ToLower() == newTransaction.Bandeira);

                return new TransactionResponse()
                {
                    ValorLiquido = newTransaction.Tipo.ToLower() == "credito"
                        ? (newTransaction.Valor - (taxa.Credito / 100))
                        : (newTransaction.Valor - (taxa.Debito / 100))
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
