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
    
    public partial class REUNIO
    {
        public REUNIO()
        {
            this.CRITERIOSPROJETOSRESULTADOes = new HashSet<CRITERIOSPROJETOSRESULTADO>();
            this.CRITERIOSRESULTADOes = new HashSet<CRITERIOSRESULTADO>();
            this.PAUTAPROJETOS = new HashSet<PAUTAPROJETO>();
            this.REUNIOESPARTICIPANTES = new HashSet<REUNIOESPARTICIPANTE>();
        }
    
        public long ID { get; set; }
        public string DESCRICAO { get; set; }
        public Nullable<System.DateTime> DATAHORAEVENTO { get; set; }
        public Nullable<System.DateTime> DATACRIACAO { get; set; }
        public Nullable<decimal> PAYBACKACEITAVEL { get; set; }
        public Nullable<decimal> TAXAREMUNERACAOMERCADO { get; set; }
        public string PAUTADESCRICAO { get; set; }
        public string LOCAL { get; set; }
        public Nullable<long> RESPONSAVEL { get; set; }
        public Nullable<byte> AHPCALCULADO { get; set; }
        public string SITUACAO { get; set; }
        public Nullable<decimal> TAXACUSTOCAPITAL { get; set; }
    
        public virtual ICollection<CRITERIOSPROJETOSRESULTADO> CRITERIOSPROJETOSRESULTADOes { get; set; }
        public virtual ICollection<CRITERIOSRESULTADO> CRITERIOSRESULTADOes { get; set; }
        public virtual ICollection<PAUTAPROJETO> PAUTAPROJETOS { get; set; }
        public virtual PESSOA PESSOA { get; set; }
        public virtual ICollection<REUNIOESPARTICIPANTE> REUNIOESPARTICIPANTES { get; set; }
    }
}