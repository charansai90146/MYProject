using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MYPROJECT.Models
{
    public class Dcondidates
    {
        [Key]  // Specifies the primary key
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Mobile { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        //[EmailAddress]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Age { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BloodGroup { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Address { get; set; }
    }
}
