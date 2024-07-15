using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTest15.Models
{
    public class Student
    {
        [Key]
        [Column("Student_Id")]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
        public List<Address> Addresses { get; set; } = new List<Address>();

        public static explicit operator Student(int v)
        {
            throw new NotImplementedException();
        }
    }
}
