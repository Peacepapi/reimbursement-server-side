using System.ComponentModel.DataAnnotations;

namespace reimbursement_server_side.Models 
{
    public class Reimbursement
    {
        [Key]
        public int rId {get; set;}
        public double rAmount {get; set;}
        [Required]
        [Timestamp]
        public byte[] rSubmitted {get; set;}
        [Timestamp]
        public byte[] rResolved {get; set;}
        public string rDescription {get; set;}
        [Required]
        public ReimbursementStatus rStatus {get; set;}
        [Required]
        public ReimbursementType rType {get; set;}
        [Required]
        public User rAuthor {get; set;}
        public User rResolver {get; set;}
    }
}