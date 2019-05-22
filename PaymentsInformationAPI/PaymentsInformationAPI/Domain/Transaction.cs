namespace PaymentsInformationAPI.Domain
{
    public class TransactionRequest
    {
        public decimal Valor { get; set; }
        public string Adquirente { get; set; }
        public string Bandeira { get; set; }
        public string Tipo { get; set; }
    }

    public class TransactionResponse
    {
        public decimal ValorLiquido { get; set; }
    }
}
