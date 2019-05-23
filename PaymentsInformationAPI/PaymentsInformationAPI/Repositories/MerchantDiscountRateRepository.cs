using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PaymentsInformationAPI.Repositories
{
    public class MerchantDiscountRateRepository : IMerchantDiscountRateRepository
    {
        private readonly IConfiguration configuration;

        public MerchantDiscountRateRepository(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IList<MerchantDiscountRate> Get()
        {
            try
            {
                using (var reader = new StreamReader(configuration.GetSection("MDR_Path").Value))
                {
                    var json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<MerchantDiscountRate>>(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MerchantDiscountRate GetByAdquirente(string adquirente)
        {
            try
            {
                using (var reader = new StreamReader(configuration.GetSection("MDR_Path").Value))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<MerchantDiscountRate>>(json);
                    return items.SingleOrDefault(i => i.Adquirente == adquirente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
