using System.ComponentModel.DataAnnotations;

namespace ASPCoreWebAppWithAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        [MaxLength(30)]
        public string EmpName { get; set; }

        public DateTime DOJ { get; set; } = DateTime.Now;
    }
}
