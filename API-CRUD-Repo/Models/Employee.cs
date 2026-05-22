using System.ComponentModel.DataAnnotations;

namespace API_CRUD_Repo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Mobile { get; set; }
        public string City { get; set; }
    }
}
