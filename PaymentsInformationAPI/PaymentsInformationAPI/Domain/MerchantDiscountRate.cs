using System.Collections.Generic;

namespace PaymentsInformationAPI.Domain
{
    public class MerchantDiscountRate
    {
        public string Adquirente { get; set; }
        public IList<Tax> Taxas { get; set; }
    }
}
