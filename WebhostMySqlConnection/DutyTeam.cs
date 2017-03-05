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
    
    public partial class DutyTeam
    {
        public DutyTeam()
        {
            this.Weekends = new HashSet<Weekend>();
            this.Members = new HashSet<Faculty>();
        }
    
        public int id { get; set; }
        public int AcademicYearID { get; set; }
        public string Name { get; set; }
        public int DTL { get; set; }
        public int AOD { get; set; }
    
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual Faculty Leader { get; set; }
        public virtual ICollection<Weekend> Weekends { get; set; }
        public virtual ICollection<Faculty> Members { get; set; }
        public virtual Faculty AdministratorOnDuty { get; set; }
    }
}