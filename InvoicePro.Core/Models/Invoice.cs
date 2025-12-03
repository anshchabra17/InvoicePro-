using System.Collections.Generic;

namespace InvoicePro.Core.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }   // e.g., "INV-2024-001"
        public int CustomerId { get; set; }
        public int VendorId { get; set; }

        public DateTime IssueDate { get; set; }
public DateTime? DueDate { get; set; }


        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; }   // Draft, Sent, Paid, Overdue

        public List<InvoiceLine> Lines { get; set; } = new();
    }
}
