namespace Incomel_Technical_Test.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String Dpi { get; set; }
        public String FullName { get; set; }
        public int ChildCount { get; set; }
        public float Salary { get; set; }
        public float Bonus { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Employee()
        {

        }
    }
}
