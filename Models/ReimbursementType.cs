using System.ComponentModel.DataAnnotations;

namespace reimbursement_server_side.Models
{
    public class ReimbursementType
    {
        [Key]
        public int rTypeId {get; set;}
        [Required]
        public string rType {get; set;}
    }
}