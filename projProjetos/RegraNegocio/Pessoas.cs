using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;
using System.Data.Linq.SqlClient;

namespace RegraNegocio
{
    public class Pessoas : Entidade
    {
        public EFDados.PESSOA entidade;

        public List<View.Pessoas.ViewPessoa> Listar()
        {
            try
            {
                return ctoProjetos.PESSOAS.AsEnumerable().Select(x => new View.Pessoas.ViewPessoa
                {
                    ID = x.ID,
                    NOME = x.NOME,
                    OBSERVACAO = x.OBSERVACAO,
                    STATUS = (x.STATUS >= (byte)1) ? ("ATIVO") : ("INATIVO")
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<View.Pessoas.ViewPessoa> Listar(CampoPessoas campo, string valor, StatusCadastro status)
        {
            try
            {
                long aux;

                List<View.Pessoas.ViewPessoa> resultado = new List<View.Pessoas.ViewPessoa>();

                switch (campo)
                {
                    case CampoPessoas.CÓDIGO:
                        if (long.TryParse(valor, out aux))
                        {
                            resultado = ctoProjetos.PESSOAS.AsEnumerable()
                                                           .Where(x => x.ID.Equals(aux))
                                                           .Select(z => new View.Pessoas.ViewPessoa
                                                           {
                                                               ID = z.ID,
                                                               NOME = z.NOME,
                                                               OBSERVACAO = z.OBSERVACAO,
                                                               STATUS = (z.STATUS >= 1) ? ("ATIVO") : ("INATIVO")
                                                           })
                                                           .ToList();
                        }
                        else
                            resultado = ctoProjetos.PESSOAS
                                                   .AsEnumerable()
                                                   .Select(z => new View.Pessoas.ViewPessoa
                                                               {
                                                                   ID = z.ID,
                                                                   NOME = z.NOME,
                                                                   OBSERVACAO = z.OBSERVACAO,
                                                                   STATUS = (z.STATUS >= 1) ? ("ATIVO") : ("INATIVO")
                                                               }).ToList();

                        break;
                    case CampoPessoas.NOME:
                        resultado = ctoProjetos.PESSOAS.AsEnumerable()
                                                       .Where(z => z.NOME.Contains(valor))
                                                       .Select(z => new View.Pessoas.ViewPessoa
                                                                        {
                                                                            ID = z.ID,
                                                                            NOME = z.NOME,
                                                                            OBSERVACAO = z.OBSERVACAO,
                                                                            STATUS = (z.STATUS >= 1) ? ("ATIVO") : ("INATIVO")
                                                       }).ToList();
                        break;
                }

                if (status.Equals(StatusCadastro.TODOS))
                    return resultado;

                resultado = resultado.Where(x => x.STATUS.Equals(status.ToString())).ToList();
                return resultado;

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
                entidade = ctoProjetos.PESSOAS.AsEnumerable().First(x => x.ID.Equals(Id));
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
                    ctoProjetos.PESSOAS.Add(entidade);
                }

                entidade.DATACRIACAO = DateTime.Now;
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
                entidade = new PESSOA();
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
                entidade = ctoProjetos.PESSOAS.First(i => i.ID == Id);
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
                if (entidade != null)
                {
                    if (entidade.STATUS >= (byte)1)
                        entidade.STATUS = (byte)0;
                    else
                        entidade.STATUS = (byte)1;

                    Salvar();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public enum CampoPessoas
    {
        CÓDIGO,
        NOME
    }

    public enum StatusCadastro
    {
        ATIVO,
        INATIVO,
        TODOS
    }
}
