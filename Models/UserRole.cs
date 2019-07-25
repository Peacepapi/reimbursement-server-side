using System.ComponentModel.DataAnnotations;

namespace reimbursement_server_side.Models
{
    public class UserRole
    {
        [Key]
        public int userRoleId {get; set;}
        [Required]
        public string userRole {get; set;}
    }
}