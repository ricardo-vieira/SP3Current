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
    
    public partial class CRITERIOSRESULTADO
    {
        public CRITERIOSRESULTADO()
        {
            this.CRITERIOSRESULTADOLISTAs = new HashSet<CRITERIOSRESULTADOLISTA>();
            this.CRITERIOSPROJETOSRESULTADOes = new HashSet<CRITERIOSPROJETOSRESULTADO>();
        }
    
        public long ID { get; set; }
        public long IDCRITERIO { get; set; }
        public Nullable<System.DateTime> DATACOMPARACAO { get; set; }
        public decimal RESULTADOCOMPARACAO { get; set; }
        public decimal RESULTADOGLOBAL { get; set; }
        public Nullable<long> IDREUNIAO { get; set; }
    
        public virtual CRITERIO CRITERIO { get; set; }
        public virtual ICollection<CRITERIOSRESULTADOLISTA> CRITERIOSRESULTADOLISTAs { get; set; }
        public virtual ICollection<CRITERIOSPROJETOSRESULTADO> CRITERIOSPROJETOSRESULTADOes { get; set; }
        public virtual REUNIO REUNIO { get; set; }
    }
}