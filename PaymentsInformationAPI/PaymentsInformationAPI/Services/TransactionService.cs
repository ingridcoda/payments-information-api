using LightInject;
using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using PaymentsInformationAPI.Services.Interfaces;

namespace PaymentsInformationAPI.Services
{
    public class TransactionService : ITransactionService
    {
        [Inject]
        public ITaxRepository TaxRepository { get; set; }

        public TransactionResponse Create(TransactionRequest newTransaction)
        {
            //var taxa = TaxRepository.GetByAdquirente(newTransaction.Adquirente);

            throw new System.NotImplementedException();
        }
    }
}
