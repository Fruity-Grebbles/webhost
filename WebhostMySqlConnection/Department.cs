//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebhostMySQLConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.Courses = new HashSet<Course>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public int DeptHeadId { get; set; }
    
        public virtual ICollection<Course> Courses { get; set; }
        public virtual Faculty DepartmentHead { get; set; }
    }
}
