//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookCenter.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSafetyBook
    {
        public int ID { get; set; }
        public Nullable<int> ReaderStuID { get; set; }
        public string BookName { get; set; }
        public Nullable<System.DateTime> SafetyDate { get; set; }
        public Nullable<int> PersonelID { get; set; }
    }
}