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
        [DisplayName("Sueldo")]
        public float Salary { get; set; }
        [DisplayName("Bono")]
        public float Bonus { get; set; }
        [DisplayName("ID Usuario")]
        public int UserId { get; set; }
        [DisplayName("Creado")]
        public DateTime CreatedAt { get; set; }

        public Employee()
        {

        }
    }
}
