using System.ComponentModel.DataAnnotations;

namespace reimbursement_server_side.Models
{
    public class ReimbursementStatus
    {
        [Key]
        public int rStatusId {get; set;}
        [Required]
        public string rStatus {get; set;}
    }
}