//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeSite1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Enrollment
    {
        public int EnrollmentID { get; set; }
        [StringLength(50)]
        public string Position { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
