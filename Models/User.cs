using System.ComponentModel.DataAnnotations;

namespace reimbursement_server_side.Models
{
    public class User
    {
        [Key]
        public int userId {get; set;}
        [Required]
        public string username {get; set;}
        [Required]
        public string password {get; set;}
        [Required]
        public string userFName {get; set;}
        [Required]
        public string userLName {get; set;}
        [Required]
        public string userEmail {get; set;}
        [Required]
        public UserRole userRole {get; set;}
    }
}