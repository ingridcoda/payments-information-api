using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using System;

namespace PaymentsInformationAPI.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public TransactionResponse Create(TransactionRequest newTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
