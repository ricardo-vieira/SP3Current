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
    
    public partial class CRITERIOSPROJETOSRESULTADO
    {
        public CRITERIOSPROJETOSRESULTADO()
        {
            this.CRITERIOSPROJETOSRESULTADOLISTAs = new HashSet<CRITERIOSPROJETOSRESULTADOLISTA>();
        }
    
        public long ID { get; set; }
        public long IDCRITERIOSRESULTADO { get; set; }
        public long IDPROJETO { get; set; }
        public decimal RESULTADO { get; set; }
        public Nullable<System.DateTime> DATACOMPARACAO { get; set; }
        public decimal RESULTADOGLOBAL { get; set; }
        public long IDREUNIAO { get; set; }
    
        public virtual CRITERIOSRESULTADO CRITERIOSRESULTADO { get; set; }
        public virtual ICollection<CRITERIOSPROJETOSRESULTADOLISTA> CRITERIOSPROJETOSRESULTADOLISTAs { get; set; }
        public virtual REUNIO REUNIO { get; set; }
        public virtual PROJETO PROJETO { get; set; }
    }
}
