using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Core.Entities
{
    [Table("PatientRecord")]
    public class PatientRecord
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? DiseaseName { get; set; }

        public DateTime TimeOfEntry { get; set; }

        public string? Description { get; set; }

        [Required]
        public decimal Bill { get; set; }

        [Required]
        public Guid PatientId { get; set; }

        public Patient? Patient { get; set; }

        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;

        public string? CreatedBy { get; set; }

        public DateTimeOffset ModifiedOn { get; set; } = DateTimeOffset.Now;

        public string? ModifiedBy { get; set; }
    }
}
