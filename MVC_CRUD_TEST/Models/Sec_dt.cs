//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_CRUD_TEST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sec_dt
    {
        public int secid { get; set; }
        public string secname { get; set; }
        public string classname { get; set; }
        public string stdroll { get; set; }
        public Nullable<int> stdid { get; set; }
    
        public virtual Std_dt Std_dt { get; set; }
    }
}
