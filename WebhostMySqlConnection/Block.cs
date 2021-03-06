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
    
    public partial class Block
    {
        public Block()
        {
            this.Sections = new HashSet<Section>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public int AcademicYearID { get; set; }
        public bool ShowInSchedule { get; set; }
        public string LongName { get; set; }
        public bool IsSpecial { get; set; }
        public bool MeetsMonday { get; set; }
        public bool MeetsTuesday { get; set; }
        public bool MeetsWednesday { get; set; }
        public bool MeetsThursday { get; set; }
        public bool MeetsFriday { get; set; }
    
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
