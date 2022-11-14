using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MultiSelect_RefreshDataAsync.Data
{
    public class EmployeeData
    {
        public int? Id { get; set; }
        public EmployeeName Name { get; set; }
        public string Title { get; set; }
    }

    public class EmployeeName
    {
        public int FirstName { get; set; }
        public Emp LastName { get; set; }
        public string Text { get; set; }
    }

    public class Emp
    {
        public int Id { get; set; }
        public string Nam { get; set; }
    }
}
