using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
    }
}
