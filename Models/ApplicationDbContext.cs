
using Microsoft.EntityFrameworkCore;

namespace reimbursement_server_side.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {
        }
        public DbSet<UserRole> UserRoles {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<ReimbursementType> ReimbursementTypes {get; set;}
        public DbSet<ReimbursementStatus> ReimbursementStatuses {get; set;}
        public DbSet<Reimbursement> Reimbursements {get; set;}
    }
}