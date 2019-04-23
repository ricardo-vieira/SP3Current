using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class Criterios : Entidade
    {
        public EFDados.CRITERIO entidade;

        public bool Incluir()
        {
            try
            {
                entidade = new EFDados.CRITERIO();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Alterar(long Id)
        {
            try
            {
                entidade = ctoProjetos.CRITERIOS.First(x => x.ID.Equals(Id));
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
                {
                    entidade.STATUS = 1;
                    ctoProjetos.CRITERIOS.Add(entidade);
                }

                entidade.DATACRIACAO = DateTime.Now.Date;

                ctoProjetos.SaveChanges();
                //InserirCriterios();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool MudarStatus(long Id)
        {
            try
            {
                EFDados.CRITERIO entidade = ctoProjetos.CRITERIOS.First(x => x.ID.Equals(Id));
                entidade.STATUS = (entidade.STATUS >= 1) ? ((byte)1) : ((byte)0);
                ctoProjetos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool MudarStatus()
        {
            try
            {
                if (entidade != null || !entidade.ID.Equals(0))
                {
                    entidade.STATUS = (entidade.STATUS >= 1) ? ((byte)1) : ((byte)0);
                    entidade.DATACRIACAO = DateTime.Now;
                    ctoProjetos.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<View.Gerencia.ViewCriterios> Listar()
        {
            try
            {
                return ctoProjetos.CRITERIOS.Select(x => new View.Gerencia.ViewCriterios
                {
                    ID = x.ID,
                    DESCRICAO = x.DESCRICAO
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public View.Gerencia.ViewCriterios Listar(long Id)
        {
            try
            {
                entidade = ctoProjetos.CRITERIOS.FirstOrDefault(x => x.ID.Equals(Id));
                return new View.Gerencia.ViewCriterios { ID = entidade.ID, DESCRICAO = entidade.DESCRICAO };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Tabela CriteriosComparacoes

        //private bool InserirCriterios()
        //{
        //    try
        //    {
        //        if (!entidade.ID.Equals(0))
        //        {
        //            List<EFDados.CRITERIO> listaCriterios = new List<EFDados.CRITERIO>();
        //            listaCriterios = ctoProjetos.CRITERIOS.AsEnumerable().Where(x => x != entidade).ToList();

        //            foreach(EFDados.CRITERIO criterio in listaCriterios)
        //            {
        //                if (!ctoProjetos.CRITERIOSCOMPARACOES.Any(y => y.IDCRITERIOA.Equals(entidade.ID) && y.IDCRITERIOB.Equals(criterio.ID)))
        //                {
        //                    ctoProjetos.CRITERIOSCOMPARACOES.Add(new EFDados.CRITERIOSCOMPARACO
        //                    {
        //                        CRITERIOA = entidade,
        //                        CRITERIOB = criterio
        //                    });
        //                    ctoProjetos.SaveChanges();
        //                }

        //                if (!ctoProjetos.CRITERIOSCOMPARACOES.Any(y => y.IDCRITERIOB.Equals(entidade.ID) && y.IDCRITERIOA.Equals(criterio.ID)))
        //                {
        //                    ctoProjetos.CRITERIOSCOMPARACOES.Add(new EFDados.CRITERIOSCOMPARACO
        //                    {
        //                        CRITERIOB = entidade,
        //                        CRITERIOA = criterio
        //                    });

        //                    ctoProjetos.SaveChanges();
        //                }

        //                if (!ctoProjetos.CRITERIOSCOMPARACOES.Any(y => y.IDCRITERIOB.Equals(entidade.ID) && y.IDCRITERIOA.Equals(entidade.ID)))
        //                {
        //                    ctoProjetos.CRITERIOSCOMPARACOES.Add(new EFDados.CRITERIOSCOMPARACO
        //                    {
        //                        CRITERIOA = entidade,
        //                        CRITERIOB = entidade,
        //                        COMPARACAO = 1.ToString()
        //                    });
        //                    ctoProjetos.SaveChanges();
        //                }
        //            };
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public System.Data.DataTable ListarCriteriosComparacoes()
        {
            System.Data.DataTable dadosTabela = new System.Data.DataTable();
            try
            {
                List<EFDados.CRITERIO> listaCriterios = ctoProjetos.CRITERIOS.AsEnumerable().OrderBy(x => x.DESCRICAO).ToList();

                dadosTabela.Columns.Add(new System.Data.DataColumn("X", typeof(string)) { ReadOnly = true });

                for (int indexCriterioColuna = 0; indexCriterioColuna < listaCriterios.Count; indexCriterioColuna++)
                    dadosTabela.Columns.Add(listaCriterios.ElementAt(indexCriterioColuna).DESCRICAO, typeof(string));

                for (int indexCriterioLinha = 0; indexCriterioLinha < listaCriterios.Count; indexCriterioLinha++)
                {

                    dadosTabela.Rows.Add(new object[] { listaCriterios.ElementAt(indexCriterioLinha).DESCRICAO });

                    for (int indexCriterioColuna = 0; indexCriterioColuna < listaCriterios.Count; indexCriterioColuna++)
                    {
                        if (listaCriterios.ElementAt(indexCriterioLinha).ID.Equals(listaCriterios.ElementAt(indexCriterioColuna).ID))
                        {
                            dadosTabela.Rows[dadosTabela.Rows.Count - 1][listaCriterios.ElementAt(indexCriterioColuna).DESCRICAO] = 1.ToString();
                        }

                        else if (ctoProjetos.CRITERIOSCOMPARACOES.AsEnumerable().Any(x => x.CRITERIOA == listaCriterios.ElementAt(indexCriterioLinha) && x.CRITERIOB == listaCriterios.ElementAt(indexCriterioColuna)))
                        {
                            EFDados.CRITERIOSCOMPARACO criterioComparacao = ctoProjetos.CRITERIOSCOMPARACOES.AsEnumerable().First(x => x.IDCRITERIOA == listaCriterios.ElementAt(indexCriterioLinha).ID && x.IDCRITERIOB == listaCriterios.ElementAt(indexCriterioColuna).ID);
                            dadosTabela.Rows[dadosTabela.Rows.Count - 1][listaCriterios.ElementAt(indexCriterioColuna).DESCRICAO] = (criterioComparacao.COMPARACAO == null) ? (1.ToString()) : (criterioComparacao.COMPARACAO);
                        }

                        else
                            dadosTabela.Rows[dadosTabela.Rows.Count - 1][listaCriterios.ElementAt(indexCriterioColuna).DESCRICAO] = 1.ToString();
                    }
                }

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SalvarCriteriosComparacoes(System.Data.DataTable dadosTabela)
        {
            try
            {
                EFDados.CRITERIOSCOMPARACO criterioComparacao;

                if (!(dadosTabela.Columns[0].ColumnName.Equals("X")) || !(dadosTabela.Rows.Count == dadosTabela.Columns.Count - 1))
                    throw new Exception("a tabela de dados passados por parametros não atende a estrutura basica da comparação de criterios");

                EFDados.CRITERIO criterioA = new EFDados.CRITERIO();
                EFDados.CRITERIO criterioB = new EFDados.CRITERIO();
                ctoProjetos.CRITERIOSCOMPARACOES.RemoveRange(ctoProjetos.CRITERIOSCOMPARACOES);
                ctoProjetos.SaveChanges();

                for (int linha = 0; linha < dadosTabela.Rows.Count; linha++)
                {
                    if (ctoProjetos.CRITERIOS.AsEnumerable().Any(x => x.DESCRICAO.Equals(dadosTabela.Rows[linha]["X"])))
                        criterioA = ctoProjetos.CRITERIOS.AsEnumerable().First(x => x.DESCRICAO.Equals(dadosTabela.Rows[linha]["X"]));

                    for (int coluna = 1; coluna < dadosTabela.Columns.Count; coluna++)
                    {
                        if (String.IsNullOrEmpty(dadosTabela.Rows[linha][coluna].ToString()))
                            throw new Exception(String.Format("Valor invalido para comparação de criterio." +
                                                "LINHA: {0} | COLUNA: {1}", dadosTabela.Rows[linha][0], dadosTabela.Columns[coluna].ColumnName));

                        if (ctoProjetos.CRITERIOS.AsEnumerable().Any(x => x.DESCRICAO.Equals(dadosTabela.Columns[coluna].ColumnName)))
                            criterioB = ctoProjetos.CRITERIOS.AsEnumerable().First(x => x.DESCRICAO.Equals(dadosTabela.Columns[coluna].ColumnName));


                        if (ctoProjetos.CRITERIOSCOMPARACOES.AsEnumerable().Any(x => x.CRITERIOA.Equals(criterioA) && x.CRITERIOB.Equals(criterioB)))
                        {
                            criterioComparacao = ctoProjetos.CRITERIOSCOMPARACOES.AsEnumerable().First(x => x.CRITERIOA.Equals(criterioA) && x.CRITERIOB.Equals(criterioB));
                            // se os criterios comparados forem os mesmos
                            criterioComparacao.COMPARACAO = (criterioA.Equals(criterioB) ? (1.ToString()) : (dadosTabela.Rows[linha][coluna].ToString()));
                        }
                        else
                        {
                            //if (!(ctoProjetos.CRITERIOS.AsEnumerable().Any(x => x.DESCRICAO.Equals(dadosTabela.Rows[linha][0])) && ctoProjetos.CRITERIOS.AsEnumerable().Any(x => x.DESCRICAO.Equals(dadosTabela.Columns[coluna].ColumnName))))
                            //    throw new Exception(String.Format("Comparação realizada entre criterios invalidos ou inexistentes no cadastro de Criterios. Verifique: LINHA = {0} | COLUNA = {1}.", dadosTabela.Rows[linha][0].ToString(), dadosTabela.Columns[coluna].ColumnName));

                            string valor = dadosTabela.Rows[linha][coluna].ToString();

                            criterioComparacao = new EFDados.CRITERIOSCOMPARACO
                            {
                                CRITERIOA = criterioA,
                                CRITERIOB = criterioB,
                                COMPARACAO = (criterioA.Equals(criterioB) ? (1.ToString()) : (dadosTabela.Rows[linha][coluna].ToString()))
                            };


                        }

                        ctoProjetos.CRITERIOSCOMPARACOES.Add(criterioComparacao);
                        ctoProjetos.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private EFDados.CRITERIOSRESULTADO CalcularCriteriosComparacoesResultado(EFDados.CRITERIO criterio)
        {
            try
            {
                double resultadoComparacao = 1;

                EFDados.CRITERIOSRESULTADO criterioResultado = new EFDados.CRITERIOSRESULTADO
                {
                    CRITERIO = criterio,
                    DATACOMPARACAO = DateTime.Now
                };

                foreach (EFDados.CRITERIOSCOMPARACO x in criterio.CRITERIOSCOMPARACOES.ToList())
                {
                    criterioResultado.CRITERIOSRESULTADOLISTAs.Add(new EFDados.CRITERIOSRESULTADOLISTA
                    {
                        CRITERIO = x.CRITERIOB,
                        COMPARACAO = x.COMPARACAO
                    });

                    switch (x.COMPARACAO)
                    {
                        case "1/3":
                            resultadoComparacao *= (double)1 / (double)3;
                            break;

                        case "1/5":
                            resultadoComparacao *= (double)1 / (double)5;
                            break;

                        case "1/7":
                            resultadoComparacao *= (double)1 / (double)7;
                            break;

                        case "1/9":
                            resultadoComparacao *= (double)1 / (double)9;
                            break;

                        case "3":
                            resultadoComparacao *= (double)3;
                            break;

                        case "5":
                            resultadoComparacao *= (double)5;
                            break;

                        case "7":
                            resultadoComparacao *= (double)7;
                            break;

                        case "9":
                            resultadoComparacao *= (double)9;
                            break;
                    }
                }
                // é a radiciação (1^(elementos do plano carteriano)
                double quantidadeElementos = Convert.ToDouble(criterioResultado.CRITERIOSRESULTADOLISTAs.Count);
                double coeficienteDeterminante = ((double)1) / quantidadeElementos;
                resultadoComparacao = Math.Pow(resultadoComparacao, coeficienteDeterminante);
                criterioResultado.RESULTADOCOMPARACAO = Convert.ToDecimal(resultadoComparacao);

                return criterioResultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Tabela CriteriosProjetosComparacoes

        public System.Data.DataTable ListarCriteriosProjetosComparacoes(object criterio)
        {
            try
            {
                System.Data.DataTable dadosTabela = new System.Data.DataTable();
                //dadosTabela.Columns.Add(new System.Data.DataColumn("x", typeof(string)));

                List<EFDados.PROJETO> listaProjetos = ctoProjetos.PROJETOS.AsEnumerable().ToList();

                for (int coluna = -1; coluna < listaProjetos.Count; coluna++)
                {
                    // se for a coluna -1, logo será a coluna com a descrição dos nomes, caso contrario será a referencia cruzada
                    dadosTabela.Columns.Add((coluna > -1) ? (listaProjetos.ElementAt(coluna).NOME) : ("X"), typeof(string));

                    for (int linha = 0; linha < listaProjetos.Count; linha++)

                        if (coluna > -1)
                        {
                            if (listaProjetos.ElementAt(coluna).Equals(listaProjetos.ElementAt(linha)))
                                dadosTabela.Rows[linha][listaProjetos.ElementAt(coluna).NOME] = 1.ToString();

                            else if (listaProjetos.ElementAt(linha).CRITERIOSPROJETOSCOMPARACOES.Any(x => x.IDCRITERIO.Equals((criterio as View.Gerencia.ViewCriterios).ID) && x.PROJETOB.Equals(listaProjetos.ElementAt(coluna))))
                                dadosTabela.Rows[linha][listaProjetos.ElementAt(coluna).NOME] = listaProjetos.ElementAt(linha).CRITERIOSPROJETOSCOMPARACOES.First(x => x.IDCRITERIO.Equals((criterio as View.Gerencia.ViewCriterios).ID) && x.PROJETOB.Equals(listaProjetos.ElementAt(coluna))).COMPARACAO;
                            else
                                dadosTabela.Rows[linha][listaProjetos.ElementAt(coluna).NOME] = 1.ToString();
                        }
                        else
                            dadosTabela.Rows.Add(new object[] { listaProjetos.ElementAt(linha).NOME.ToString() });
                }

                return dadosTabela;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SalvarCriterioProjetosComparacoes(object criterio, System.Data.DataTable dadosTabela)
        {
            try
            {
                EFDados.CRITERIOSPROJETOSCOMPARACO criterioProjetoComparacao;

                ctoProjetos.CRITERIOSPROJETOSCOMPARACOES.RemoveRange(ctoProjetos.CRITERIOSPROJETOSCOMPARACOES.AsEnumerable().Where(x => x.IDCRITERIO.Equals((criterio as View.Gerencia.ViewCriterios).ID)));
                ctoProjetos.SaveChanges();

                if (!(criterio != null && (criterio is EFDados.CRITERIO || criterio is View.Gerencia.ViewCriterios) && ctoProjetos.CRITERIOS.AsEnumerable().Any(x => x.ID.Equals((criterio as View.Gerencia.ViewCriterios).ID))))
                    throw new Exception("O criterio passado não pode ser nulo ou deve pertencer ao banco de dados.");

                if (!(dadosTabela.Columns[0].ColumnName.Equals("X") && dadosTabela.Rows.Count == dadosTabela.Columns.Count - 1))
                    throw new Exception("a fonte de dados indicada não está no formato adequado.");

                EFDados.PROJETO projetoA, projetoB;

                for (int linha = 0; linha < dadosTabela.Rows.Count; linha++)
                {
                    if (!ctoProjetos.PROJETOS.AsEnumerable().Any(x => x.NOME.Equals(dadosTabela.Rows[linha]["X"].ToString())))
                        throw new Exception(String.Format("Não existe nenhum projeto cadastrado com o mesmo nome na linha especificada. linha {0} NOME = {1}", linha, dadosTabela.Rows[linha]["X"].ToString()));

                    projetoA = ctoProjetos.PROJETOS.AsEnumerable().First(x => x.NOME.Equals(dadosTabela.Rows[linha]["X"].ToString()));

                    for (int coluna = 1; coluna < dadosTabela.Columns.Count; coluna++)
                    {
                        if (!ctoProjetos.PROJETOS.AsEnumerable().Any(x => x.NOME.Equals(dadosTabela.Columns[coluna].ColumnName.ToString())))
                            throw new Exception(String.Format("Não existe nenhum projeto cadastrado com o mesmo nome na coluna especificada. coluna {0} NOME = {1}", coluna, dadosTabela.Rows[linha][coluna].ToString()));

                        projetoB = ctoProjetos.PROJETOS.AsEnumerable().First(x => x.NOME.Equals(dadosTabela.Columns[coluna].ColumnName.ToString()));

                        if (projetoA.Equals(projetoB))
                        {
                            if (ctoProjetos.CRITERIOSPROJETOSCOMPARACOES.AsEnumerable().Any(x => x.IDCRITERIO.Equals((criterio as View.Gerencia.ViewCriterios).ID) && x.PROJETOA.Equals(projetoA) && x.PROJETOB.Equals(projetoB)))
                                criterioProjetoComparacao = ctoProjetos.CRITERIOSPROJETOSCOMPARACOES.AsEnumerable().First(x => x.ID.Equals((criterio as View.Gerencia.ViewCriterios).ID) && x.PROJETOA.Equals(projetoA) && x.PROJETOB.Equals(projetoB));
                            else
                                criterioProjetoComparacao = new EFDados.CRITERIOSPROJETOSCOMPARACO
                                {
                                    IDCRITERIO = Convert.ToInt64((criterio as View.Gerencia.ViewCriterios).ID),
                                    PROJETOA = projetoA,
                                    PROJETOB = projetoB
                                };

                            criterioProjetoComparacao.COMPARACAO = 1.ToString();
                        }
                        else if (ctoProjetos.CRITERIOSPROJETOSCOMPARACOES.AsEnumerable().Any(x => x.IDCRITERIO.Equals((criterio as View.Gerencia.ViewCriterios).ID) && x.PROJETOA.Equals(projetoA) && x.PROJETOB.Equals(projetoB)))
                        {
                            criterioProjetoComparacao = ctoProjetos.CRITERIOSPROJETOSCOMPARACOES.AsEnumerable().First(x => x.CRITERIO.ID.Equals((criterio as View.Gerencia.ViewCriterios).ID) && x.PROJETOA.Equals(projetoA) && x.PROJETOB.Equals(projetoB));
                            criterioProjetoComparacao.COMPARACAO = dadosTabela.Rows[linha][coluna].ToString();
                        }
                        else
                        {
                            criterioProjetoComparacao = new EFDados.CRITERIOSPROJETOSCOMPARACO();

                            criterioProjetoComparacao.IDCRITERIO = Convert.ToInt64((criterio as View.Gerencia.ViewCriterios).ID);
                            criterioProjetoComparacao.PROJETOA = projetoA;

                            if (projetoA.Equals(projetoB))
                            {
                                criterioProjetoComparacao.PROJETOB = projetoA; // já que é o mesmo projeto na linha e na coluna
                                criterioProjetoComparacao.COMPARACAO = 1.ToString();
                            }
                            else
                            {
                                criterioProjetoComparacao.PROJETOB = projetoB;
                                criterioProjetoComparacao.COMPARACAO = dadosTabela.Rows[linha][coluna].ToString();
                            }

                            ctoProjetos.CRITERIOSPROJETOSCOMPARACOES.Add(criterioProjetoComparacao);
                        }


                    }
                }

                ctoProjetos.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EFDados.CRITERIOSPROJETOSRESULTADO CalcularCriteriosProjetosResultado(EFDados.CRITERIOSRESULTADO criterioResultado, EFDados.REUNIO reuniao, EFDados.PROJETO projeto)
        {
            try
            {
                double resultadoCriterioComparacao = 1;

                EFDados.CRITERIOSPROJETOSRESULTADO criterioProjetoResultado = new EFDados.CRITERIOSPROJETOSRESULTADO
                {
                    CRITERIOSRESULTADO = criterioResultado,
                    IDREUNIAO = reuniao.ID,
                    IDPROJETO = projeto.ID,
                    DATACOMPARACAO = DateTime.Now,
                    RESULTADO = 1
                };

                List<EFDados.CRITERIOSPROJETOSCOMPARACO> listaCriteriosProjetosComparacao = projeto.CRITERIOSPROJETOSCOMPARACOES
                                                                                                   .AsEnumerable()
                                                                                                   .Where(criterioprojeto => criterioprojeto.IDCRITERIO == criterioResultado.CRITERIO.ID
                                                                                                                             && reuniao.PAUTAPROJETOS.AsEnumerable().Any(pautaprojeto => pautaprojeto.IDPROJETO == criterioprojeto.IDPROJETOB))
                                                                                                   .ToList();


                //somente irá trazer os projetos com o criterioComparação indicado e que os projetos estejam contidos na reunião.
                foreach (EFDados.CRITERIOSPROJETOSCOMPARACO x in listaCriteriosProjetosComparacao)
                {
                    criterioProjetoResultado.CRITERIOSPROJETOSRESULTADOLISTAs.Add(new EFDados.CRITERIOSPROJETOSRESULTADOLISTA
                    {
                        IDPROJETO = x.IDPROJETOB.Value,
                        COMPARACAO = x.COMPARACAO
                    });

                    switch (x.COMPARACAO)
                    {
                        case "1/3":
                            resultadoCriterioComparacao *= (double)1 / (double)3;
                            break;

                        case "1/5":
                            resultadoCriterioComparacao *= (double)1 / (double)5;
                            break;

                        case "1/7":
                            resultadoCriterioComparacao *= (double)1 / (double)7;
                            break;

                        case "1/9":
                            resultadoCriterioComparacao *= (double)1 / (double)9;
                            break;

                        case "3":
                            resultadoCriterioComparacao *= (double)3;
                            break;

                        case "5":
                            resultadoCriterioComparacao *= (double)5;
                            break;

                        case "7":
                            resultadoCriterioComparacao *= (double)7;
                            break;

                        case "9":
                            resultadoCriterioComparacao *= (double)9;
                            break;
                    }

                }

                double quantidadeElementos = criterioProjetoResultado.CRITERIOSPROJETOSRESULTADOLISTAs.Count + 1;
                double coeficienteDeterminante = ((double)1) / quantidadeElementos;
                resultadoCriterioComparacao = Math.Pow(resultadoCriterioComparacao, coeficienteDeterminante);
                criterioProjetoResultado.RESULTADO = Convert.ToDecimal(resultadoCriterioComparacao);

                return criterioProjetoResultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
    }
        #endregion

        public List<EFDados.CRITERIOSPROJETOSRESULTADO> CalcularPrioridadeGlobalProjeto(EFDados.REUNIO reuniao)
        {
            try
            {
                double projetoResultadoGlobal = 0;

                List<EFDados.CRITERIOSRESULTADO> listaCriterioResultado = new List<EFDados.CRITERIOSRESULTADO>();
                List<EFDados.CRITERIOSPROJETOSRESULTADO> listacriteriosProjetoResultado = new List<EFDados.CRITERIOSPROJETOSRESULTADO>();

                EFDados.CRITERIOSRESULTADO criterioResultado;
                EFDados.CRITERIOSPROJETOSRESULTADO criterioProjetoResultado;

                listaCriterioResultado.Clear();
                ctoProjetos.CRITERIOS.AsEnumerable().ToList().ForEach(x =>
                {
                    criterioResultado = CalcularCriteriosComparacoesResultado(x);
                    listaCriterioResultado.Add(criterioResultado);
                });

                foreach (EFDados.PAUTAPROJETO pautaProjeto in reuniao.PAUTAPROJETOS)
                {
                    foreach (var criterioR in listaCriterioResultado)
                    {
                        //double somaResultadoComparacao = Convert.ToDouble(listaCriterioResultado.Sum(z => z.RESULTADOCOMPARACAO));
                        criterioR.RESULTADOGLOBAL = criterioR.RESULTADOCOMPARACAO / listaCriterioResultado.Sum(z => z.RESULTADOCOMPARACAO);

                        criterioProjetoResultado = CalcularCriteriosProjetosResultado(criterioR, reuniao, pautaProjeto.PROJETO);
                        listacriteriosProjetoResultado.Add(criterioProjetoResultado);
                    }
                }

                foreach (EFDados.CRITERIOSPROJETOSRESULTADO criterioProjetoR in listacriteriosProjetoResultado)
                {
                    criterioProjetoR.RESULTADOGLOBAL = criterioProjetoR.RESULTADO / listacriteriosProjetoResultado.Where(x => x.CRITERIOSRESULTADO.CRITERIO.Equals(criterioProjetoR.CRITERIOSRESULTADO.CRITERIO)).Sum(z => z.RESULTADO);
                    //projetoResultadoGlobal += Convert.ToDouble(criterioProjetoR.RESULTADOGLOBAL) * Convert.ToDouble(criterioProjetoR.CRITERIOSRESULTADO.RESULTADOGLOBAL);
                }

                foreach (var cpr in listacriteriosProjetoResultado)
                {
                    var cprsExcluir = ctoProjetos.CRITERIOSPROJETOSRESULTADOes
                                                 .AsEnumerable()
                                                 .Where(x => x.IDREUNIAO.Equals(reuniao.ID)
                                                             && x.IDPROJETO.Equals(cpr.PROJETO.ID)
                                                             && x.CRITERIOSRESULTADO.CRITERIO.Equals(cpr.CRITERIOSRESULTADO.CRITERIO));

                        ctoProjetos.CRITERIOSPROJETOSRESULTADOes.RemoveRange(cprsExcluir);

                    ctoProjetos.CRITERIOSPROJETOSRESULTADOes.Add(cpr);
                }

                return listacriteriosProjetoResultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
