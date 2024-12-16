using Microsoft.EntityFrameworkCore;
using ClientPortalManagement.Models;

namespace ClientPortalManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
