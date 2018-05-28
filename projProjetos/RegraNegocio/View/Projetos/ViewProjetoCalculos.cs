using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    public class ViewPautaProjetoCalculos : ViewPautaProjetos
    {


        public decimal? RESULTADOPAYBACK { get; set; }
        public int? ORDEMRESULTADOPAYBACK { get; set; }
        public string APROVACAORESULTADOPAYBACK { get; set; }

        public decimal? RESULTADOTAXAINTERNARETORNO { get; set; }
        public int? ORDEMRESULTADOTAXAINTERNARETORNO { get; set; }
        public string APROVACAORESULTADOTAXAINTERNARETORNO { get; set; }

        //public decimal? RESULTADORETORNOSOBREINVESTIMENTO { get; set; }
        //public int? ORDEMRESULTADORETORNOSOBREINVESTIMENTO { get; set; }
        //public string APROVACAORESULTADORETORNOSOBREINVESTIMENTO { get; set; }

        public decimal? RESULTADOVALORPRESENTELIQUIDO { get; set; }
        public int? ORDEMRESULTADOVALORPRESENTELIQUIDO { get; set; }
        public string APROVACAORESULTADOVALORPRESENTELIQUIDO { get; set; }

        public string RESULTADODICE { get; set; }
        public int? ORDEMRESULTADODICE { get; set; }
        public string APROVACAORESULTADODICE { get; set; }

        public decimal? RESULTADOAHP { get; set; }
        public int? ORDEMRESULTADOAHP { get; set; }
        public string APROVACAORESULTADOAHP { get; set; }

        public string AHPCALCULADO { get; set; }


    }
}
