//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AustOldBook
{
    using System;
    using System.Collections.Generic;
    
    public partial class LogInInfo
    {
        public int logInId { get; set; }
        public string userId { get; set; }
        public Nullable<int> checkLog { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}