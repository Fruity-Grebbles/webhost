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
    
    public partial class StudentSignup
    {
        public int StudentId { get; set; }
        public int ActivityId { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public bool IsRescended { get; set; }
        public bool IsBanned { get; set; }
        public bool Attended { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual WeekendActivity WeekendActivity { get; set; }
    }
}