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
    
    public partial class GradeTable
    {
        public GradeTable()
        {
            this.GradeTableEntries = new HashSet<GradeTableEntry>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public int AcademicYearID { get; set; }
    
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ICollection<GradeTableEntry> GradeTableEntries { get; set; }
    }
}