using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    /// <summary>
    /// Classe para representação de consulta basica de Projetos
    /// </summary>
    public class ViewProjeto : IView<EFDados.PROJETO>
    {
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public string OBSERVACAO { get; set; }
        public string GERENTEPROJETO { get; set; }
        public decimal? INVESTIMENTOPREVISTO { get; set; }
        public decimal? RECEITACONSTANTE { get; set; }
        public decimal? RAZAORECEITAVALOR { get; set; }
        public decimal? RAZAORECEITAPERCENTUAL { get; set; }
        public decimal? TEMPOPREVISTOCONCLUSAO { get; set; }
        public string STATUS { get; set; }
    }
}
