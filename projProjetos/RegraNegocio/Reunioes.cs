using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class Reunioes : EFDados.Entity<EFDados.REUNIO>
    {
        private EFDados.dbProjetosEntities ctoProjetos = new EFDados.dbProjetosEntities();

        public List<RegraNegocio.View.Reunioes.ViewReuniao> ToList()
        {
            try
            {
                return base.ToList().Select(x => new View.Reunioes.ViewReuniao(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.REUNIO Insert()
        {
            try
            {
                var entidade = base.Insert();
                entidade.SITUACAO = "EM OPERAÇÃO";
                entidade.DATACRIACAO = DateTime.Now;
                return entidade;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.REUNIO Update(EFDados.REUNIO reuniao)
        {
            try
            {
                var entidade = base.Update(reuniao);
                entidade.DATAHORAEVENTO = DateTime.Now;
                return entidade;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(EFDados.REUNIO reuniao)
        {
            try
            {
                return base.Delete(reuniao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MudarSituacao(EFDados.REUNIO reuniao, SituacaoReuniao situacao)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;

                if (situacao.Equals(SituacaoReuniao.EFETIVADO) && entidade.PAUTAPROJETOS.Count <= 0)
                    throw new Exception("Reunião sem projetos lançados na pauta.");

                switch (situacao)
                {
                    case SituacaoReuniao.OPERAÇÃO:
                        break;
                    case SituacaoReuniao.EFETIVADO:
                        EfetivarReuniao(reuniao);
                        entidade.SITUACAO = "EFETIVADO";
                        break;
                    case SituacaoReuniao.CANCELADO:
                        entidade.SITUACAO = "CANCELADO";
                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RegraNegocio.View.Projetos.ViewPautaProjeto> ListarProjetosCalculados(EFDados.REUNIO reuniao)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;

                if (entidade != null && (entidade.SITUACAO == "EFETIVADO" || entidade.PAUTAPROJETOS.Count > 0 && entidade.SITUACAO == "CANCELADO"))
                {

                    List<View.Projetos.ViewPautaProjeto> listaProjetosCalculos;

                    listaProjetosCalculos = new List<View.Projetos.ViewPautaProjeto>(entidade.PAUTAPROJETOS.Select(x => new RegraNegocio.View.Projetos.ViewPautaProjeto(x)).ToList());
                    return listaProjetosCalculos;
                }
                else
                    return new List<View.Projetos.ViewPautaProjeto>(new List<View.Projetos.ViewPautaProjeto>());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<View.Projetos.ViewPautaProjeto> ListarPautaProjeto(EFDados.REUNIO reuniao)
        {
            try
            {

                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;

                return reuniao.PAUTAPROJETOS
                           .Select(x => new View.Projetos.ViewPautaProjeto(x))
                           .ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PAUTAPROJETO RetornarPautaProjeto(EFDados.REUNIO reuniao, long IdPautaProjeto)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                return entidade.PAUTAPROJETOS.FirstOrDefault(x => x.ID.Equals(IdPautaProjeto));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EFDados.PAUTAPROJETO ListarPautaProjetoSemId(EFDados.REUNIO reuniao, long IdProjeto)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                return entidade.PAUTAPROJETOS.First(x => x.IDPROJETO.Equals(IdProjeto));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirPautaProjeto(EFDados.REUNIO reuniao, EFDados.PAUTAPROJETO pautaprojeto)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                var pauta = entidade.PAUTAPROJETOS.First(x => x == pautaprojeto);
                entidade.PAUTAPROJETOS.Remove(pauta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PAUTAPROJETO AlterarPautaProjeto(EFDados.REUNIO reuniao, EFDados.PAUTAPROJETO pautaprojeto)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                var pauta = entidade.PAUTAPROJETOS.First(x => x == pautaprojeto);

                return pauta;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public EFDados.PAUTAPROJETO IncluirPautaProjeto(EFDados.REUNIO reuniao)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                var pautaProjeto = new EFDados.PAUTAPROJETO();
                entidade.PAUTAPROJETOS.Add(pautaProjeto);
                return pautaProjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SalvarPautaProjeto(EFDados.REUNIO reuniao, EFDados.PAUTAPROJETO pautaProjeto)
        {
            try
            {

                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                pautaProjeto.REUNIO = reuniao;
                //CopiarInformacoesPautaProjeto(pautaProjeto);

                if (!entidade.PAUTAPROJETOS.Contains(pautaProjeto))
                    entidade.PAUTAPROJETOS.Add(pautaProjeto);

                entidade.AHPCALCULADO = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int? CalcularIndiceTempoPrevistoConclusao(decimal? tempoPrevistoConclusao)
        {
            if (tempoPrevistoConclusao != null)
            {
                if (tempoPrevistoConclusao > 8)
                    return 4;
                else if (tempoPrevistoConclusao >= 4 && tempoPrevistoConclusao <= 8)
                    return 3;
                else if (tempoPrevistoConclusao >= 2 && tempoPrevistoConclusao <= 4)
                    return 2;
                else if (tempoPrevistoConclusao >= 0 && tempoPrevistoConclusao <= 2)
                    return 1;
            }

            return null;
        }

        public void CalcularAHP(EFDados.REUNIO reuniao)
        {
            try
            {
                List<EFDados.CRITERIOSPROJETOSRESULTADO> criteriosProjetosResultado = new Criterios().CalcularPrioridadeGlobalProjeto(reuniao);
                double resultado;

                foreach (EFDados.PAUTAPROJETO pautaProjeto in reuniao.PAUTAPROJETOS.ToList())
                {
                    resultado = 0;

                    foreach (var criterioProjetoR in criteriosProjetosResultado.Where(x => x.IDPROJETO.Equals(ctoProjetos.PROJETOS.First(z => z.ID.Equals(pautaProjeto.IDPROJETO)).ID)))
                    {
                        criterioProjetoR.RESULTADOGLOBAL = Convert.ToDecimal(Convert.ToDouble(criterioProjetoR.RESULTADOGLOBAL) * Convert.ToDouble(criterioProjetoR.CRITERIOSRESULTADO.RESULTADOGLOBAL));
                        resultado += Convert.ToDouble(criterioProjetoR.RESULTADOGLOBAL);
                    }

                    pautaProjeto.RESULTADOAHP = Convert.ToDecimal(resultado * 100);
                }


                reuniao.AHPCALCULADO = (byte)1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarExistenciaProjetoPautaProjeto(EFDados.REUNIO reuniao, long idProjeto)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                return entidade.PAUTAPROJETOS.Any(x => x.IDPROJETO.Equals(idProjeto));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<FluxoCaixa> CalcularFluxoCaixa(EFDados.PAUTAPROJETO pautaProjeto)
        {
            List<FluxoCaixa> fc = new List<FluxoCaixa>();

            pautaProjeto.PAUTARECEITAVARIAVELs.ToList().ForEach(x =>
            {
                if (fc.Any(flu => flu.Mes == x.DATACRIACAO.Value.Month && flu.Ano == x.DATACRIACAO.Value.Year))
                {
                    FluxoCaixa fluxo = fc.First(flu => flu.Mes == x.DATACRIACAO.Value.Month && flu.Ano == x.DATACRIACAO.Value.Year);
                    fluxo.valor += (x.TIPO.Equals("RECEITA")) ? (Convert.ToDouble(x.VALOR)) : (-Convert.ToDouble(x.VALOR));
                }
                else
                    fc.Add(new FluxoCaixa { Mes = x.DATACRIACAO.Value.Month, Ano = x.DATACRIACAO.Value.Year, valor = (x.TIPO.Equals("RECEITA")) ? (Convert.ToDouble(x.VALOR)) : (-Convert.ToDouble(x.VALOR)) });

            });

            return fc;
        }

        private double[] calcularVPLTIR(EFDados.PAUTAPROJETO pautaProjeto)
        {
            var entidade = pautaProjeto.IDREUNIAO != 0 ? base.DbEntity.First(x => x.ID.Equals(pautaProjeto.IDREUNIAO)) : pautaProjeto.REUNIO;
            List<FluxoCaixa> fluxoCaixa = CalcularFluxoCaixa(pautaProjeto);

            //Cálculo do VPL
            double vpl = 0;
            int size = fluxoCaixa.Count;
            double prepot = 1 + Convert.ToDouble(entidade.TAXACUSTOCAPITAL) / 100;

            vpl = -Convert.ToDouble(pautaProjeto.INVESTIMENTOPREVISTO);

            for (int t = 0; t < size; t++)
            {
                double pot = Math.Pow(prepot, t + 1);
                vpl += fluxoCaixa.ElementAt(t).valor / pot;
            }

            //Cálculo da TIR    
            double tir = 0.0001;
            double aux;

            do
            {
                //aux = Convert.ToDouble(pautaProjeto.INVESTIMENTOPREVISTO);
                aux = 0;
                tir += 0.0001;

                for (int i = 0; i < size; i++)
                    aux += fluxoCaixa.ElementAt(i).valor / Math.Pow((1 + tir), i + 1);
                aux += -Convert.ToDouble(pautaProjeto.INVESTIMENTOPREVISTO);
            } while (aux > 0);


            return new double[] { vpl, tir };

        }

        private bool IncluirProjetoPauta(EFDados.REUNIO reuniao, long Id)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                EFDados.PAUTAPROJETO pautaProjeto = new EFDados.PAUTAPROJETO
                {
                    IDPROJETO = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).ID,

                    PAUTARECEITAVARIAVELs = new System.Collections.ObjectModel.Collection<EFDados.PAUTARECEITAVARIAVEL>(
                                                    (from receita in ctoProjetos.RECEITAVARIAVELs
                                                     where receita.IDPROJETO == Id
                                                     select new
                                                     {
                                                         PERIODO = receita.DATAPERIODO,
                                                         VALOR = receita.VALOR,
                                                         OBSERVACOES = receita.OBSERVACOES,
                                                         TIPO = receita.TIPO,
                                                         DATACRIACAO = receita.DATAPERIODO
                                                 //STATUS = (byte)receita.STATUS,
                                             }).ToList().Select(x => new EFDados.PAUTARECEITAVARIAVEL
                                                     {
                                                         DATAPERIODO = x.PERIODO,
                                                         VALOR = x.VALOR,
                                                         OBSERVACOES = x.OBSERVACOES,
                                                         TIPO = x.TIPO,
                                                         DATACRIACAO = x.DATACRIACAO
                                                 //STATUS = x.STATUS
                                             }).ToList()),

                    RAZAORECEITAPERCENTUAL = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).RAZAORECEITAPERCENTUAL,
                    RAZAORECEITAVALOR = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).RAZAORECEITAVALOR,
                    RECEITACONSTANTE = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).RECEITACONSTANTE,
                    TEMPOPREVISTOCONCLUSAO = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).TEMPOPREVISTOCONCLUSAO,
                    APOIOALTAGESTAO = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).APOIOALTAGESTAO,
                    APOIOSTEAKHOLDERS = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).APOIOSTEAKHOLDERS,
                    CAPACIDADEENTREGAEQUPE = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).CAPACIDADEENTREGAEQUIPE,
                    ESFORCOADICIONAL = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).ESFORCOADICIONAL,
                    INVESTIMENTOPREVISTO = ctoProjetos.PROJETOS.FirstOrDefault(i => i.ID.Equals(Id)).INVESTIMENTOPREVISTO

                };
                //ao inserir um novo projeto, o mesmo fica não calculado
                entidade.AHPCALCULADO = (byte)0;

                entidade.PAUTAPROJETOS.Add(pautaProjeto);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ExcluirProjetoPauta(EFDados.REUNIO reuniao, long IdProjeto)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                entidade.PAUTAPROJETOS.Remove(ctoProjetos.PAUTAPROJETOS.First(i => i.IDPROJETO.Equals(IdProjeto)));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*private void CopiarInformacoesPautaProjeto(EFDados.PAUTAPROJETO pautaProjeto)
        {
            try
            {
                EFDados.PROJETO projeto = ctoProjetos.PROJETOS.AsEnumerable().First(x => x.ID == pautaProjeto.PROJETO.ID]);

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
        } */

        private void CalcularPriorizacao(EFDados.REUNIO reuniao)
        {
            try
            {
                var entidade = reuniao;
                List<FluxoCaixa> fluxoCaixa;

                entidade.PAUTAPROJETOS.ToList().ForEach(x =>
                {
                    fluxoCaixa = CalcularFluxoCaixa(x);
                    x.RESULTADOPAYBACK = (fluxoCaixa.Count > 0 && fluxoCaixa.Sum(z => z.valor) > 0) ? (x.INVESTIMENTOPREVISTO / Convert.ToDecimal(fluxoCaixa.Average(z => z.valor))) : (x.INVESTIMENTOPREVISTO / x.TEMPOPREVISTOCONCLUSAO);
                    x.RESULTADOVALORPRESENTELIQUIDO = Convert.ToDecimal(calcularVPLTIR(x)[0]);
                    x.RESULTADOTAXAINTERNARETORNO = Convert.ToDecimal(calcularVPLTIR(x)[1]);
                    x.RESULTADODICE = CalcularIndiceTempoPrevistoConclusao(x.TEMPOPREVISTOCONCLUSAO) + 2 * x.CAPACIDADEENTREGAEQUPE + 2 * x.APOIOALTAGESTAO + x.APOIOSTEAKHOLDERS + x.ESFORCOADICIONAL;
                    x.RESULTADOTAXAINTERNARETORNO = Convert.ToDecimal(calcularVPLTIR(x)[1]) * 100;
                    x.RESULTADOVALORPRESENTELIQUIDO = Convert.ToDecimal(calcularVPLTIR(x)[0]);
                });


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void OrdenarValoresPriorizacao(EFDados.REUNIO reuniao)
        {
            try
            {
                var entidade = reuniao;

                int contador = 1;
                entidade.PAUTAPROJETOS.OrderBy(x => x.RESULTADOPAYBACK).ToList().ForEach(z => z.ORDEMRESULTADOPAYBACK = contador++);

                contador = 1;
                entidade.PAUTAPROJETOS.OrderByDescending(x => x.RESULTADOTAXAINTERNARETORNO).ToList().ForEach(z => z.ORDEMRESULTADOTAXAINTERNARETORNO = contador++);

                contador = 1;
                entidade.PAUTAPROJETOS.OrderByDescending(x => x.RESULTADOVALORPRESENTELIQUIDO).ToList().ForEach(z => z.ORDEMRESULTADOVALORPRESENTELIQUIDO = contador++);

                contador = 1;
                entidade.PAUTAPROJETOS.OrderBy(x => x.RESULTADODICE).ToList().ForEach(z => z.ORDEMRESULTADODICE = contador++);

                contador = 1;
                entidade.PAUTAPROJETOS.OrderByDescending(x => x.RESULTADOAHP).ToList().ForEach(z => z.ORDEMRESULTADOAHP = contador++);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EfetivarReuniao(EFDados.REUNIO reuniao)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;

                if (entidade.PAUTAPROJETOS.Count <= 0)
                    throw new Exception("Não é possivel efetivar a reunião, pois a mesma não possui nenhum projeto pautado.");

                entidade.SITUACAO = "EFETIVADO";
                CalcularPriorizacao(reuniao);
                OrdenarValoresPriorizacao(reuniao);
                Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CancelarReuniao(EFDados.REUNIO reuniao)
        {
            try
            {
                var entidade = reuniao.ID != 0 ? base.DbEntity.First(x => x.ID == reuniao.ID) : reuniao;
                entidade.SITUACAO = "CANCELADO";
                Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    class FluxoCaixa
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public double valor { get; set; }
    }

    public enum SituacaoReuniao
    {
        OPERAÇÃO,
        EFETIVADO,
        CANCELADO
    }
}