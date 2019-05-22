using PaymentsInformationAPI.Domain;

namespace PaymentsInformationAPI.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        TransactionResponse Create(TransactionRequest newTransaction);
    }
}
