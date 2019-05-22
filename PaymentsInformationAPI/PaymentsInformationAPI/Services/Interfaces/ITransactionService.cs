using PaymentsInformationAPI.Domain;

namespace PaymentsInformationAPI.Services.Interfaces
{
    public interface ITransactionService
    {
        TransactionResponse Create(TransactionRequest newTransaction);
    }
}
