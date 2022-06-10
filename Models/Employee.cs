using System.ComponentModel;

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
        public int UserId { get; set; }

        [DisplayName("Creado")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("IGSS (Q.)")]
        public float Igss => Salary * .0483f;

        [DisplayName("IRTRA (Q.)")]
        public float Irtra => Salary * .01f;

        [DisplayName("Bono de Paternidad (Q.)")]
        public float PaternityBonus => 133 * ChildCount;

        [DisplayName("Salario Total (Q.)")]
        public float TotalSalary => Salary + PaternityBonus + Bonus;

        [DisplayName("Salario Líquido (Q.)")]
        public float LiquidSalary => TotalSalary - Igss - Irtra;

        public Employee()
        {

        }
    }
}
