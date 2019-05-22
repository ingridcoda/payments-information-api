using PaymentsInformationAPI.Domain;

namespace PaymentsInformationAPI.Services.Interfaces
{
    public interface ITaxService
    {
        Tax GetByAdquirente(string adquirente);
    }
}
