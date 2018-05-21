using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Pessoas
{
    /// <summary>
    /// Classe para representação de consulta de Pessoas
    /// </summary>
    public class ViewPessoa : View.IView<EFDados.PESSOA>
    {
        public string  NOME { get; set; }
        public string OBSERVACAO { get; set; }
        public string STATUS { get; set; }
    }
}
