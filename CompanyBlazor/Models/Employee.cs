using System.ComponentModel.DataAnnotations;

namespace CompanyBlazor.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MinLength(3,ErrorMessage ="Name Must Be More Than 2 Letter")]
        [MaxLength(25,ErrorMessage ="Name Must BE Less Than 25 letter")]
        public string Name { get; set; }

        [Range(6000,25000)]
        public int Salary { get; set; }
        public string Image { get; set; }
        public int Dept_Id { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} - Salary : {Salary}";
        }
    }
}
