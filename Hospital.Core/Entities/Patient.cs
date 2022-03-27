using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Core.Entities
{
    [Table("Patient")]
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int SystemIdNumber { get; set; }

        [Required]
        public string? OfficialIdNumber { get; set; }

        [Required]
        public string? Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? EmailAddress { get; set; }

        public ICollection<PatientRecord> PatientRecords { get; set; } = new HashSet<PatientRecord>();

        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;

        public string? CreatedBy { get; set; }

        public DateTimeOffset ModifiedOn { get; set; } = DateTimeOffset.Now;

        public string? ModifiedBy { get; set; }
    }
}
