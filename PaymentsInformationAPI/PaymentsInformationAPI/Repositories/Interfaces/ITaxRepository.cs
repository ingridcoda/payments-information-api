using PaymentsInformationAPI.Domain;

namespace PaymentsInformationAPI.Repositories.Interfaces
{
    public interface ITaxRepository
    {
        Tax GetByAdquirente(string adquirente);
    }
}
