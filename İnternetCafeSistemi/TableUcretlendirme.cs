//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace İnternetCafeSistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableUcretlendirme
    {
        public int UcretID { get; set; }
        public Nullable<int> OturumID { get; set; }
        public string AcilisTipi { get; set; }
    
        public virtual TableOturumlar TableOturumlar { get; set; }
    }
}
