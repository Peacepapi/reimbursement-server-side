
using Microsoft.EntityFrameworkCore;

namespace reimbursement_server_side.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {

        }
    }
}