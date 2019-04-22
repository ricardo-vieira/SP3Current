using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;

namespace RegraNegocio
{
    public class PautaProjetos : Entity<EFDados.PAUTAPROJETO>
    {
        public List<RegraNegocio.View.Projetos.ViewPautaProjeto> ToList()
        {
            try
            {
                return base.ToList().Select(x => new View.Projetos.ViewPautaProjeto(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PAUTAPROJETO Insert()
        {
            try
            {
                return base.Insert();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PAUTAPROJETO Update(EFDados.PAUTAPROJETO pautaProjeto)
        {
            try
            {
                return base.Update(pautaProjeto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(EFDados.PAUTAPROJETO pautaProjeto)
        {
            try
            {
                return base.Delete(pautaProjeto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Commit()
        {
            base._addedItens.ForEach(pj => CopiarInformacoesPautaProjeto(pj));
            return base.Commit();
        }

        private void CopiarInformacoesPautaProjeto(EFDados.PAUTAPROJETO pautaProjeto)
        {
            try
            {
                EFDados.PROJETO projeto = base.CtoProjetos.PROJETOS.AsEnumerable().First(x => x.ID == pautaProjeto.PROJETO.ID);

                pautaProjeto.APOIOALTAGESTAO = projeto.APOIOALTAGESTAO;

                pautaProjeto.APOIOSTEAKHOLDERS = projeto.APOIOSTEAKHOLDERS;
                pautaProjeto.CAPACIDADEENTREGAEQUPE = projeto.APOIOSTEAKHOLDERS;
                pautaProjeto.ESFORCOADICIONAL = projeto.ESFORCOADICIONAL;

                pautaProjeto.INVESTIMENTOPREVISTO = projeto.INVESTIMENTOPREVISTO;
                pautaProjeto.RAZAORECEITAPERCENTUAL = projeto.RAZAORECEITAPERCENTUAL;
                pautaProjeto.RAZAORECEITAVALOR = projeto.RAZAORECEITAVALOR;
                pautaProjeto.TEMPOPREVISTOCONCLUSAO = projeto.TEMPOPREVISTOCONCLUSAO;

                pautaProjeto.PAUTARECEITAVARIAVELs.ToList().ForEach(x => pautaProjeto.PAUTARECEITAVARIAVELs.Remove(x));

                projeto.RECEITAVARIAVELs.ToList().ForEach(x =>
                {
                    pautaProjeto.PAUTARECEITAVARIAVELs.Add(new EFDados.PAUTARECEITAVARIAVEL
                    {
                        DATACRIACAO = x.DATACRIACAO,
                        DATAPERIODO = x.DATAPERIODO,
                        OBSERVACOES = x.OBSERVACOES,
                        STATUS = x.STATUS,
                        TIPO = x.TIPO,
                        VALOR = x.VALOR
                    });
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
