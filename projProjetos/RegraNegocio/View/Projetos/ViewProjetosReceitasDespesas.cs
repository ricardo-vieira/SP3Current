using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    public class ViewProjetosReceitasDespesas
    {
        public long IDPROJETO { get; set; }
        public System.DateTime DATAPERIODO { get; set; }
        public string TIPO { get; set; }
        public double VALOR { get; set; }
        public string OBSERVACOES { get; set; }
    }
}
