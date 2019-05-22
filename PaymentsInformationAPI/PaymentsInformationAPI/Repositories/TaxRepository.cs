using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace PaymentsInformationAPI.Repositories
{
    public class TaxRepository : ITaxRepository
    {
        private List<Tax> Taxas { get; set; }
        public Tax GetByAdquirente(string adquirente)
        {
            throw new NotImplementedException();
        }
    }
}
