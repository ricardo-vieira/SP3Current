//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDados
{
    using System;
    using System.Collections.Generic;
    
    public partial class CRITERIOSCOMPARACO
    {
        public int ID { get; set; }
        public long IDCRITERIOA { get; set; }
        public long IDCRITERIOB { get; set; }
        public string COMPARACAO { get; set; }
    
        public virtual CRITERIO CRITERIOA { get; set; }
        public virtual CRITERIO CRITERIOB { get; set; }
    }
}