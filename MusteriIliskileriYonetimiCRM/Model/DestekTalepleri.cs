//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusteriIliskileriYonetimiCRM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DestekTalepleri
    {
        public int Id { get; set; }
        public string SiparisId { get; set; }
        public int KategoriId { get; set; }
        public string Talep { get; set; }
        public string YoneticiCevap { get; set; }
        public System.DateTime TalepTarihi { get; set; }
        public Nullable<System.DateTime> IslemTarihi { get; set; }
        public bool TamamlandiMi { get; set; }
        public int MusteriId { get; set; }
    
        public virtual DestekKategorileri DestekKategorileri { get; set; }
        public virtual Siparisler Siparisler { get; set; }
        public virtual Musteriler Musteriler { get; set; }
    }
}
