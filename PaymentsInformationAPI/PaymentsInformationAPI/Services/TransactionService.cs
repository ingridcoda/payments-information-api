using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using PaymentsInformationAPI.Services.Interfaces;
using System;

namespace PaymentsInformationAPI.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository TransactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            TransactionRepository = transactionRepository;
        }

        public TransactionResponse Create(TransactionRequest newTransaction)
        {
            try
            {
                var transaction = TransactionRepository.Create(newTransaction);
                return transaction;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
