using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace HRManager.Entities
{
    public class HRManagerUser : IdentityUser
    {
        public decimal? Salary { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
