using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;
using RegraNegocio.View.Pessoas;

namespace RegraNegocio
{
    public class Projetos : Entidade
    {
        public EFDados.PROJETO entidade;

        public EFDados.RECEITAVARIAVEL receitaDespesa;
        public EFDados.PROJETOSPESSOA participanteProjeto;

        public List<View.Projetos.ViewProjeto> Listar()
        {
            try
            {
                return ctoProjetos.PROJETOS.Select(x => new View.Projetos.ViewProjeto()
                {
                    ID = x.ID,
                    DESCRICAO = x.DESCRICAO,
                    GERENTEPROJETO = x.GERENTEPROJETO.NOME,
                    INVESTIMENTOPREVISTO = x.INVESTIMENTOPREVISTO,
                    NOME = x.NOME,
                    OBSERVACAO = x.OBSERVACAO,
                    RAZAORECEITAPERCENTUAL = x.RAZAORECEITAPERCENTUAL,
                    RAZAORECEITAVALOR = x.RAZAORECEITAVALOR,
                    RECEITACONSTANTE = x.RECEITACONSTANTE,
                    STATUS = (x.STATUS >= 1) ? ("ATIVO") : ("INATIVO"),
                    TEMPOPREVISTOCONCLUSAO = x.TEMPOPREVISTOCONCLUSAO
                }).ToList();

                //IEnumerable<EFDados.PROJETO> enumeradoProjetos = from i in ctoProjetos.PROJETOS select i;
                //return enumeradoProjetos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<View.Projetos.ViewProjeto> Listar(CampoProjetos campo, string valor, StatusCadastro status)
        {
            try
            {
                List<View.Projetos.ViewProjeto> resultado = new List<View.Projetos.ViewProjeto>();
                long aux;

                switch (campo)
                {
                    case CampoProjetos.CÓDIGO:
                        resultado = ctoProjetos.PROJETOS.AsEnumerable()                                                  //condição qualquwr para trazer todos
                                                        .Where(z => long.TryParse(valor, out aux) && z.ID.Equals(aux) || aux == 0 && z.ID > 0)
                                                        .Select(x => new View.Projetos.ViewProjeto
                                                        {
                                                            ID = x.ID,
                                                            DESCRICAO = x.DESCRICAO,
                                                            GERENTEPROJETO = x.GERENTEPROJETO.NOME,
                                                            INVESTIMENTOPREVISTO = x.INVESTIMENTOPREVISTO,
                                                            NOME = x.NOME,
                                                            OBSERVACAO = x.OBSERVACAO,
                                                            RAZAORECEITAPERCENTUAL = x.RAZAORECEITAPERCENTUAL,
                                                            RAZAORECEITAVALOR = x.RAZAORECEITAVALOR,
                                                            RECEITACONSTANTE = x.RECEITACONSTANTE,
                                                            STATUS = (x.STATUS >= 1) ? ("ATIVO") : ("INATIVO"),
                                                            TEMPOPREVISTOCONCLUSAO = x.TEMPOPREVISTOCONCLUSAO
                                                        }).ToList();
                        break;

                    case CampoProjetos.DESCRIÇÃO:
                        resultado = ctoProjetos.PROJETOS.AsEnumerable()
                                                        .Where(x => x.DESCRICAO.Contains(valor))
                                                        .Select(x => new View.Projetos.ViewProjeto
                                                        {
                                                            ID = x.ID,
                                                            DESCRICAO = x.DESCRICAO,
                                                            GERENTEPROJETO = x.GERENTEPROJETO.NOME,
                                                            INVESTIMENTOPREVISTO = x.INVESTIMENTOPREVISTO,
                                                            NOME = x.NOME,
                                                            OBSERVACAO = x.OBSERVACAO,
                                                            RAZAORECEITAPERCENTUAL = x.RAZAORECEITAPERCENTUAL,
                                                            RAZAORECEITAVALOR = x.RAZAORECEITAVALOR,
                                                            RECEITACONSTANTE = x.RECEITACONSTANTE,
                                                            STATUS = (x.STATUS >= 1) ? ("ATIVO") : ("INATIVO"),
                                                            TEMPOPREVISTOCONCLUSAO = x.TEMPOPREVISTOCONCLUSAO
                                                        }).ToList();

                        break;

                    case CampoProjetos.GERENTE:
                        resultado = ctoProjetos.PROJETOS.AsEnumerable()
                                                        .Where(x => x.GERENTEPROJETO.NOME.Contains(valor))
                                                        .Select(x => new View.Projetos.ViewProjeto
                                                        {
                                                            ID = x.ID,
                                                            DESCRICAO = x.DESCRICAO,
                                                            GERENTEPROJETO = x.GERENTEPROJETO.NOME,
                                                            INVESTIMENTOPREVISTO = x.INVESTIMENTOPREVISTO,
                                                            NOME = x.NOME,
                                                            OBSERVACAO = x.OBSERVACAO,
                                                            RAZAORECEITAPERCENTUAL = x.RAZAORECEITAPERCENTUAL,
                                                            RAZAORECEITAVALOR = x.RAZAORECEITAVALOR,
                                                            RECEITACONSTANTE = x.RECEITACONSTANTE,
                                                            STATUS = (x.STATUS >= 1) ? ("ATIVO") : ("INATIVO"),
                                                            TEMPOPREVISTOCONCLUSAO = x.TEMPOPREVISTOCONCLUSAO
                                                        }).ToList();
                        break;

                    case CampoProjetos.NOME:
                        resultado = ctoProjetos.PROJETOS.AsEnumerable()
                                                        .Where(x => x.NOME.Contains(valor))
                                                        .Select(x => new View.Projetos.ViewProjeto
                                                        {
                                                            ID = x.ID,
                                                            DESCRICAO = x.DESCRICAO,
                                                            GERENTEPROJETO = x.GERENTEPROJETO.NOME,
                                                            INVESTIMENTOPREVISTO = x.INVESTIMENTOPREVISTO,
                                                            NOME = x.NOME,
                                                            OBSERVACAO = x.OBSERVACAO,
                                                            RAZAORECEITAPERCENTUAL = x.RAZAORECEITAPERCENTUAL,
                                                            RAZAORECEITAVALOR = x.RAZAORECEITAVALOR,
                                                            RECEITACONSTANTE = x.RECEITACONSTANTE,
                                                            STATUS = (x.STATUS >= 1) ? ("ATIVO") : ("INATIVO"),
                                                            TEMPOPREVISTOCONCLUSAO = x.TEMPOPREVISTOCONCLUSAO
                                                        }).ToList();
                        break;

                    case CampoProjetos.OBSERVAÇÃO:
                        resultado = ctoProjetos.PROJETOS.AsEnumerable()
                                                        .Where(x => x.OBSERVACAO.Contains(valor))
                                                        .Select(x => new View.Projetos.ViewProjeto
                                                        {
                                                            ID = x.ID,
                                                            DESCRICAO = x.DESCRICAO,
                                                            GERENTEPROJETO = x.GERENTEPROJETO.NOME,
                                                            INVESTIMENTOPREVISTO = x.INVESTIMENTOPREVISTO,
                                                            NOME = x.NOME,
                                                            OBSERVACAO = x.OBSERVACAO,
                                                            RAZAORECEITAPERCENTUAL = x.RAZAORECEITAPERCENTUAL,
                                                            RAZAORECEITAVALOR = x.RAZAORECEITAVALOR,
                                                            RECEITACONSTANTE = x.RECEITACONSTANTE,
                                                            STATUS = (x.STATUS >= 1) ? ("ATIVO") : ("INATIVO"),
                                                            TEMPOPREVISTOCONCLUSAO = x.TEMPOPREVISTOCONCLUSAO
                                                        }).ToList();
                        break;
                }

                if (status.Equals(StatusCadastro.TODOS))
                    return resultado;


                   return resultado.Where(x => x.STATUS.Equals(status.ToString())).ToList();
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
                entidade = ctoProjetos.PROJETOS.First(i => i.ID == Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Salvar()
        {
            try
            {
                if (entidade.ID.Equals(0))
                {
                    entidade.STATUS = 1;
                    ctoProjetos.PROJETOS.Add(entidade);
                }

                entidade.DATACRIACAO = DateTime.Now.Date;
                ctoProjetos.SaveChanges();

                this.entidade = null;
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
                entidade = new PROJETO();
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
                entidade = ctoProjetos.PROJETOS.First(i => i.ID == Id);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void MudarStatus()
        {
            try
            {
                entidade.STATUS = (entidade.STATUS == 1) ? ((byte)0) : ((byte)1);
                this.Salvar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Listagem com entidades diferentes de projetos

        public List<View.Pessoas.ViewPessoa> ListarPessoas()
        {
            try
            {
                Pessoas pessoas = new Pessoas();
                return pessoas.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void IncluirReceitaDespesaVariavel()
        {
            try
            {
                receitaDespesa = new RECEITAVARIAVEL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirReceitaDespesaVariavel()
        {
            try
            {
                if (receitaDespesa != null)
                    entidade.RECEITAVARIAVELs.Remove(receitaDespesa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void IncluirParticipanteProjeto()
        {
            try
            {
                participanteProjeto = new PROJETOSPESSOA();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirParticipanteProjeto()
        {
            try
            {
                if (entidade != null)
                    entidade.PROJETOSPESSOAS.Remove(participanteProjeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarReceitaDespesaVariavel()
        {
            try
            {
                if (entidade != null)
                {
                    receitaDespesa.DATACRIACAO = DateTime.Now;

                    if (receitaDespesa.IDPROJETO.Equals(0))
                        entidade.RECEITAVARIAVELs.Add(receitaDespesa);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarParticipanteProjeto()
        {
            try
            {
                if (participanteProjeto.ID.Equals(0))
                    entidade.PROJETOSPESSOAS.Add(participanteProjeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<View.Projetos.ViewProjetosReceitasDespesas> ListarReceitasDespesas()
        {
            try
            {
                return entidade.RECEITAVARIAVELs.Select(x => new View.Projetos.ViewProjetosReceitasDespesas
                {
                    IDPROJETO = x.IDPROJETO,
                    DATAPERIODO = x.DATAPERIODO,
                    TIPO = (x.TIPO.Equals("D")) ? ("DESPESA") : ("RECEITA"),
                    VALOR = Convert.ToDouble(x.VALOR),
                    OBSERVACOES = x.OBSERVACOES
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ListarReceitasDespesas(DateTime dataReceitaDespesaPeriodo)
        {
            try
            {
                if (entidade != null)
                    receitaDespesa = entidade.RECEITAVARIAVELs.FirstOrDefault(x => x.DATAPERIODO.Equals(dataReceitaDespesaPeriodo));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<View.Pessoas.ViewPessoasParticipantesProjetos> ListarParticipantesProjetos()
        {
            try
            {
                return entidade.PROJETOSPESSOAS.Select(x => new ViewPessoasParticipantesProjetos
                {
                    ID = x.IDPESSOA,
                    DATAINGRESSO = x.DATAINGRESSO,
                    NOME = ctoProjetos.PESSOAS.AsEnumerable().FirstOrDefault(p => p.ID.Equals(x.IDPESSOA)).NOME,
                    OBSERVACOESPARTICIPANTE = x.OBSERVACOES,
                    OCUPACAO = x.OCUPACAO.ToString()
                    //IDPROJETO = x.PROJETO.ID
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ListarParticipantesProjetos(long? idParticipanteProjeto)
        {
            try
            {
                if (entidade != null)
                    participanteProjeto = entidade.PROJETOSPESSOAS.FirstOrDefault(x => x.IDPESSOA.Equals(idParticipanteProjeto));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion



    }

    public enum CampoProjetos
    {
        CÓDIGO,
        NOME,
        DESCRIÇÃO,
        GERENTE,
        OBSERVAÇÃO,
    }
}
