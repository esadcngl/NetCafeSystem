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
    
    public partial class TableSatis
    {
        public int SatısID { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public Nullable<int> MasaID { get; set; }
        public Nullable<System.DateTime> BaslangicZamani { get; set; }
        public Nullable<System.DateTime> BitisZamani { get; set; }
        public string AcilisTuru { get; set; }
        public Nullable<int> KullanilanSüre { get; set; }
        public Nullable<decimal> Ucret { get; set; }
    }
}
