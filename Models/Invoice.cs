namespace ClientPortalManagement.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int ClientId { get; set; }
    }
}
