//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
       
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<System.DateTime> hire_date { get; set; }
        public Nullable<int> salary { get; set; }
        public Nullable<int> department_id { get; set; }
    }
}
