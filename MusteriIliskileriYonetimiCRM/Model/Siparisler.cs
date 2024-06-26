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
    
    public partial class Siparisler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparisler()
        {
            this.DestekTalepleri = new HashSet<DestekTalepleri>();
            this.Siparis_Detay = new HashSet<Siparis_Detay>();
        }
    
        public string Id { get; set; }
        public Nullable<int> MusteriId { get; set; }
        public Nullable<System.DateTime> SiparisTarihi { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
        public Nullable<System.DateTime> IptalTarihi { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public Nullable<int> Kargo_Id { get; set; }
        public string TeslimSehri { get; set; }
        public string TeslimAdresi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestekTalepleri> DestekTalepleri { get; set; }
        public virtual KargoFirmalari KargoFirmalari { get; set; }
        public virtual Musteriler Musteriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis_Detay> Siparis_Detay { get; set; }
    }
}
