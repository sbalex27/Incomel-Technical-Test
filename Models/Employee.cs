using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incomel_Technical_Test.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [DisplayName("DPI")]
        public String Dpi { get; set; }

        [DisplayName("Nombre Completo")]
        public String FullName { get; set; }

        [DisplayName("Cantidad de Hijos")]
        public int ChildCount { get; set; }

        [DisplayName("Sueldo (Q.)")]
        public float Salary { get; set; }

        [DisplayName("Bono (Q.)")]
        public float Bonus { get; set; }

        [DisplayName("ID Usuario")]
        [ValidateNever]
        public String UserId { get; set; }
        [DisplayName("Creado Por")]
        [ValidateNever]
        public User User { get; set; }

        [DisplayName("Creado el")]
        [ValidateNever]
        public DateTime CreatedAt { get; set; }

        [DisplayName("IGSS (Q.)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float Igss => Salary * .0483f;

        [DisplayName("IRTRA (Q.)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float Irtra => Salary * .01f;

        [DisplayName("Bono de Paternidad (Q.)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float PaternityBonus => 133 * ChildCount;

        [DisplayName("Salario Total (Q.)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float TotalSalary => Salary + PaternityBonus + Bonus;

        [DisplayName("Salario Líquido (Q.)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float LiquidSalary => TotalSalary - Igss - Irtra;

        public Employee()
        {

        }
    }
}
