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
    
    public partial class PESSOA
    {
        public PESSOA()
        {
            this.PESSOACOMPETENCIAS = new HashSet<PESSOACOMPETENCIA>();
            this.PROJETOSPESSOAS = new HashSet<PROJETOSPESSOA>();
            this.REUNIOESPARTICIPANTES = new HashSet<REUNIOESPARTICIPANTE>();
            this.REUNIOES = new HashSet<REUNIO>();
            this.PROJETOS = new HashSet<PROJETO>();
        }
    
        public long ID { get; set; }
        public string NOME { get; set; }
        public string OBSERVACAO { get; set; }
        public Nullable<System.DateTime> DATACRIACAO { get; set; }
        public Nullable<byte> STATUS { get; set; }
    
        public virtual ICollection<PESSOACOMPETENCIA> PESSOACOMPETENCIAS { get; set; }
        public virtual ICollection<PROJETOSPESSOA> PROJETOSPESSOAS { get; set; }
        public virtual ICollection<REUNIOESPARTICIPANTE> REUNIOESPARTICIPANTES { get; set; }
        public virtual ICollection<REUNIO> REUNIOES { get; set; }
        public virtual ICollection<PROJETO> PROJETOS { get; set; }
    }
}