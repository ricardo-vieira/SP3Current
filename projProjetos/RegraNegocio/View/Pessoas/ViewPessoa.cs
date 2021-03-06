﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Pessoas
{
    /// <summary>
    /// Classe para representação de consulta de Pessoas
    /// </summary>
    public class ViewPessoa : View.ViewEntity<EFDados.PESSOA>
    {
        public long? Id { get => base.EntityObject.ID; }
        public string Nome { get => base.EntityObject.NOME ?? String.Empty; }
        public string Status { get => (base.EntityObject.STATUS == 1) ? ("ATIVO") : ("INATIVO"); }
        public string Observacao { get => base.EntityObject.OBSERVACAO ?? String.Empty; }
        public DateTime? DataCriacao { get => base.EntityObject.DATACRIACAO; }

        public ViewPessoa(EFDados.PESSOA pessoa) : base(pessoa)
        {
        }

        #region Auxiliares de Filtro

        public bool SelecaoGerente { get; set; }
        public bool SelecaoResponsavel { get; set; }

        #endregion

    }
}
