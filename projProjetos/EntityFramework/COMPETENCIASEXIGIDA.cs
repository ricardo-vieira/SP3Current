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
    
    public partial class COMPETENCIASEXIGIDA
    {
        public long IDPROJETO { get; set; }
        public long IDCOMPETENCIA { get; set; }
        public Nullable<int> NIVEL { get; set; }
        public string OBSERVACOES { get; set; }
        public Nullable<byte> STATUS { get; set; }
    
        public virtual COMPETENCIA COMPETENCIA { get; set; }
        public virtual PROJETO PROJETO { get; set; }
    }
}
