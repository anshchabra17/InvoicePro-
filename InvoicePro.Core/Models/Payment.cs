namespace InvoicePro.Core.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public string Method { get; set; }   // UPI, Cash, Bank, Card
        public string? ReferenceNumber { get; set; }
    }
}
