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
    
    public partial class Siparis_Detay
    {
        public string SiparisId { get; set; }
        public int UrunId { get; set; }
        public decimal Urun_Fiyat { get; set; }
        public short Adet { get; set; }
        public int Id { get; set; }
    
        public virtual Siparisler Siparisler { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
