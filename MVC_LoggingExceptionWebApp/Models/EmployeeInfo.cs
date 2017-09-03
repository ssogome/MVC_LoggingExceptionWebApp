using System.ComponentModel.DataAnnotations;

namespace MVC_LoggingExceptionWebApp.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
    }
}