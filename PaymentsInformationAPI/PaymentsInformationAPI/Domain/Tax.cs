namespace PaymentsInformationAPI.Domain
{
    public class Tax
    {
        public Bandeira Bandeira { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
    }

    public enum Bandeira
    {
        Visa,
        Master
    }
}
