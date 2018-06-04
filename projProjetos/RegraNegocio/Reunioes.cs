using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class Reunioes : Entidade
    {
        public EFDados.REUNIO entidade;
        public EFDados.PAUTAPROJETO pautaProjeto;

        public List<RegraNegocio.View.Reunioes.ViewReuniao> Listar()
        {
            try
            {
                return ctoProjetos.REUNIOES.Select(i => new RegraNegocio.View.Reunioes.ViewReuniao
                {
                    ID = i.ID,
                    DESCRICAO = i.DESCRICAO,
                    DATAHORAEVENTO = i.DATAHORAEVENTO,
                    RESPONSAVEL = i.PESSOA.NOME,
                    LOCAL = i.LOCAL,
                    PAUTADESCRICAO = i.PAUTADESCRICAO,
                    PAYBACKACEITAVEL = i.PAYBACKACEITAVEL,
                    QUANTIDADEPROJETOSPAUTA = i.PAUTAPROJETOS.Count,
                    TAXAREMUNERACAOMERCADO = i.TAXAREMUNERACAOMERCADO,
                    SITUACAO = i.SITUACAO
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RegraNegocio.View.Reunioes.ViewReuniao> Listar(long? IdReuniao, DateTime dataPeriodo, params SituacaoReuniao[] situacao)
        {
            try
            {
                List<SituacaoReuniao> situacaoReuniao = situacao.ToList();

                if (IdReuniao.Equals(null))
                {
                    List<RegraNegocio.View.Reunioes.ViewReuniao> resultado;

                    resultado = ctoProjetos.REUNIOES.AsEnumerable()
                                                    .Where(x => x.DATAHORAEVENTO.Value.Date == dataPeriodo.Date
                                                                && (x.SITUACAO.Equals("EM OPERAÇÃO") && situacaoReuniao.Contains(SituacaoReuniao.OPERAÇÃO)
                                                                    || x.SITUACAO.Equals("EFETIVADO") && situacaoReuniao.Contains(SituacaoReuniao.EFETIVADO)
                                                                    || x.SITUACAO.Equals("CANCELADO") && situacaoReuniao.Contains(SituacaoReuniao.CANCELADO)))
                                                    .Select(i => new View.Reunioes.ViewReuniao
                                                    {
                                                        ID = i.ID,
                                                        DESCRICAO = i.DESCRICAO,
                                                        DATAHORAEVENTO = i.DATAHORAEVENTO,
                                                        RESPONSAVEL = i.PESSOA.NOME,
                                                        LOCAL = i.LOCAL,
                                                        PAUTADESCRICAO = i.PAUTADESCRICAO,
                                                        PAYBACKACEITAVEL = i.PAYBACKACEITAVEL,
                                                        QUANTIDADEPROJETOSPAUTA = i.PAUTAPROJETOS.Count,
                                                        TAXAREMUNERACAOMERCADO = i.TAXAREMUNERACAOMERCADO,
                                                        SITUACAO = i.SITUACAO
                                                    }).ToList();

                    return resultado;
                }

                return ctoProjetos.REUNIOES.AsEnumerable()
                                            .Where(x => x.ID.Equals(IdReuniao) 
                                                        && (x.SITUACAO.Equals("EM OPERAÇÃO") && situacaoReuniao.Contains(SituacaoReuniao.OPERAÇÃO)
                                                                    || x.SITUACAO.Equals("EFETIVADO") && situacaoReuniao.Contains(SituacaoReuniao.EFETIVADO)
                                                                    || x.SITUACAO.Equals("CANCELADO") && situacaoReuniao.Contains(SituacaoReuniao.CANCELADO)))
                                            .Select(i => new View.Reunioes.ViewReuniao
                                            {
                                                ID = i.ID,
                                                DESCRICAO = i.DESCRICAO,
                                                DATAHORAEVENTO = i.DATAHORAEVENTO,
                                                RESPONSAVEL = i.PESSOA.NOME,
                                                LOCAL = i.LOCAL,
                                                PAUTADESCRICAO = i.PAUTADESCRICAO,
                                                PAYBACKACEITAVEL = i.PAYBACKACEITAVEL,
                                                QUANTIDADEPROJETOSPAUTA = i.PAUTAPROJETOS.Count,
                                                TAXAREMUNERACAOMERCADO = i.TAXAREMUNERACAOMERCADO,
                                                SITUACAO = i.SITUACAO
                                            }).ToList();



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Listar(long Id)
        {
            try
            {
                entidade = ctoProjetos.REUNIOES.FirstOrDefault(x => x.ID.Equals(Id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Incluir()
        {
            try
            {
                entidade = new EFDados.REUNIO();
                entidade.SITUACAO = "EM OPERAÇÃO";
                entidade.AHPCALCULADO = 0;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Salvar()
        {
            try
            {
                if (entidade.ID.Equals(0))
                    ctoProjetos.REUNIOES.Add(entidade);

                CalcularPriorizacao();
                OrdenarValoresPriorizacao();

                ctoProjetos.SaveChanges();

                entidade = null;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool MudarSituacao(SituacaoReuniao situacao)
        {
            try
            {
                if (situacao.Equals(SituacaoReuniao.EFETIVADO) && entidade.PAUTAPROJETOS.Count <= 0)
                    throw new Exception("Reunião sem projetos lançados na pauta.");

                switch (situacao)
                {
                    case SituacaoReuniao.OPERAÇÃO:
                        break;
                    case SituacaoReuniao.EFETIVADO:
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

        public Binding.SortableBindingList<RegraNegocio.View.Projetos.ViewPautaProjeto> ListarProjetosCalculados()
        {
            try
            {
                if (entidade != null && (entidade.SITUACAO.Equals("EFETIVADO") || entidade.PAUTAPROJETOS.Count > 0 && entidade.SITUACAO.Equals("CANCELADO")))
                {

                    Binding.SortableBindingList<View.Projetos.ViewPautaProjeto> listaProjetosCalculos;

                    listaProjetosCalculos = new Binding.SortableBindingList<View.Projetos.ViewPautaProjeto>(entidade.PAUTAPROJETOS.Select(x => new RegraNegocio.View.Projetos.ViewPautaProjeto(x)).ToList());

                    return listaProjetosCalculos;
                }
                else
                    return new Binding.SortableBindingList<View.Projetos.ViewPautaProjeto>(new List<View.Projetos.ViewPautaProjeto>());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<View.Projetos.ViewPautaProjeto> ListarPautaProjeto()
        {
            try
            {
                return entidade.PAUTAPROJETOS.Select(x => new View.Projetos.ViewPautaProjeto(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ListarPautaProjetos(long IdPautaProjeto)
        {
            try
            {
                pautaProjeto = entidade.PAUTAPROJETOS.FirstOrDefault(x => x.ID.Equals(IdPautaProjeto));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ListarPautaProjetoSemId(long IdProjeto)
        {
            try
            {
                pautaProjeto = entidade.PAUTAPROJETOS.First(x => x.IDPROJETO.Equals(IdProjeto));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirPautaProjeto()
        {
            try
            {
                entidade.PAUTAPROJETOS.Remove(pautaProjeto);
                pautaProjeto = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirPautaProjeto()
        {
            try
            {
                pautaProjeto = new EFDados.PAUTAPROJETO();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SalvarPautaProjeto()
        {
            try
            {
                CopiarInformacoesPautaProjeto();

                if (pautaProjeto.ID.Equals(0))
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



        public void CalcularAHP()
        {
            try
            {
                List<EFDados.CRITERIOSPROJETOSRESULTADO> criteriosProjetosResultado = new Criterios().CalcularPrioridadeGlobalProjeto(entidade);

                double resultado;

                foreach (EFDados.PAUTAPROJETO pautaProjeto in entidade.PAUTAPROJETOS)
                {
                    resultado = 0;

                    foreach (var criterioProjetoR in criteriosProjetosResultado.Where(x => x.PROJETO.Equals(ctoProjetos.PROJETOS.First(z => z.ID.Equals(pautaProjeto.IDPROJETO)))))
                    {
                        criterioProjetoR.RESULTADOGLOBAL = Convert.ToDecimal(Convert.ToDouble(criterioProjetoR.RESULTADOGLOBAL) * Convert.ToDouble(criterioProjetoR.CRITERIOSRESULTADO.RESULTADOGLOBAL));
                        resultado += Convert.ToDouble(criterioProjetoR.RESULTADOGLOBAL);
                    }

                    pautaProjeto.RESULTADOAHP = Convert.ToDecimal(resultado * 100);
                }


                entidade.AHPCALCULADO = (byte)1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarExistenciaProjetoPautaProjeto()
        {
            try
            {
                return entidade.PAUTAPROJETOS.Any(x => x.IDPROJETO.Equals(pautaProjeto.IDPROJETO));
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

        private bool IncluirProjetoPauta(long Id)
        {
            try
            {
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

        private bool ExcluirProjetoPauta(long IdProjeto)
        {
            try
            {
                entidade.PAUTAPROJETOS.Remove(ctoProjetos.PAUTAPROJETOS.First(i => i.IDPROJETO.Equals(IdProjeto)));
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CopiarInformacoesPautaProjeto()
        {
            try
            {
                EFDados.PROJETO projeto = ctoProjetos.PROJETOS.AsEnumerable().First(x => x.ID.Equals(pautaProjeto.IDPROJETO));

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

        private void CalcularPriorizacao()
        {
            try
            {
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

        private void OrdenarValoresPriorizacao()
        {
            try
            {
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

        private void EfetivarReuniao()
        {
            try
            {
                if (entidade.PAUTAPROJETOS.Count <= 0)
                    throw new Exception("Não é possivel efetivar a reunião, pois a mesma não possui nenhum projeto pautado.");

                entidade.SITUACAO = "EFETIVADO";

                Salvar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CancelarReuniao()
        {
            try
            {
                entidade.SITUACAO = "CANCELADO";

                Salvar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MetodoTeste(EFDados.PAUTAPROJETO paua)
        {
            EFDados.PAUTAPROJETO teste = paua;
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




