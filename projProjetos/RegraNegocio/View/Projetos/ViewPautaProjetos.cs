using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    public class ViewPautaProjetos : RegraNegocio.View.Projetos.ViewProjeto
    {
        public long? IDPAUTAPROJETOS { get; set; }

        public int? CAPACIDADEENTREGAEQUIPE { get; set; }
        public int? APOIOALTAGESTAO { get; set; }
        public int? APOIOSTEAKHOLDERS { get; set; }
        public int? ESFORCOADICIONAL { get; set; }

        public decimal? TOTALVALORRECEITAPREVISTA { get; set; }
        public decimal? TOTALVALORDESPESAPREVISTA { get; set; }
    }
}
