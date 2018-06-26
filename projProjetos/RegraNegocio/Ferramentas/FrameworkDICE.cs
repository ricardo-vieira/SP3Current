using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.Ferramentas
{
    public class FrameworkDICE
    {
        public static string RetornarStatusDice(int? dice)
        {
            if (dice > 17)
                return "Probabilidade de insucesso. (" + dice + ") ";
            else if (dice > 14)
                return " Sucesso preocupante. (" + dice + ")";
            else
                return " Alta probabilidade de sucesso. (" + dice + ")";
        }

        public static string RetornarDescricaoApoioSteakHolders(int? indiceApoioSteakHolders)
        {
            string strApoioSteakHolders = String.Empty;

            switch (indiceApoioSteakHolders)
            {
                case 0:
                    strApoioSteakHolders = "Anciosos";
                    break;

                case 1:
                    strApoioSteakHolders = "Dispostos";
                    break;

                case 2:
                    strApoioSteakHolders = "Relutantes";
                    break;

                case 3:
                    strApoioSteakHolders = "Fortemente Relutantes";
                    break;

                default:
                    break;
            }

            return strApoioSteakHolders;
        }

        public static string RetornarDescricaoCapacidadeEntregaEquipe(int? indiceCapacidadeEntrega)
        {
            string strCapacidadeEntregaEquipe = String.Empty;

            switch (indiceCapacidadeEntrega)
            {
                case 0:
                    strCapacidadeEntregaEquipe = "Muito Bom";
                    break;

                case 1:
                    strCapacidadeEntregaEquipe = "Bom";
                    break;

                case 2:
                    strCapacidadeEntregaEquipe = "Médio";
                    break;

                case 3:
                    strCapacidadeEntregaEquipe = "Pobre";
                    break;

                default:
                    break;
            }

            return strCapacidadeEntregaEquipe;
        }

        public static string RetornarDescricaoApoioAltaGestao(int? indiceApoioAltaGestao)
        {
            string strApoioAltaGestao = String.Empty;

            switch (indiceApoioAltaGestao)
            {
                case 0:
                    strApoioAltaGestao = "Apoio Formal e Total";
                    break;

                case 1:
                    strApoioAltaGestao = "Desejam o Sucesso";
                    break;

                case 2:
                    strApoioAltaGestao = "Neutro";
                    break;

                case 3:
                    strApoioAltaGestao = "Relutantes";
                    break;

                default:
                    break;
            }

            return strApoioAltaGestao;
        }


        public static int? RetornarIndiceApoioSteakHolders(string strApoioSteakHolders)
        {
            int? indexApoioAltaGestao = null;

            switch (strApoioSteakHolders.ToUpper())
            {
                case "ANCIOSOS":
                    indexApoioAltaGestao = 0;
                    break;

                case "DISPOSTOS":
                    indexApoioAltaGestao = 1;
                    break;

                case "RELUTANTES":
                    indexApoioAltaGestao = 2;
                    break;

                case "FORTEMENTE RELUTANTES":
                    indexApoioAltaGestao = 3;
                    break;

                default:
                    break;
            }

            return indexApoioAltaGestao;
        }

        public static int? RetornarIndiceCapacidadeEntregaEquipe(string strCapacidadeEntregaEquipe)
        {
            int? indexCapacidadeEntregaEquipe = null;

            switch (strCapacidadeEntregaEquipe.ToUpper())
            {
                case "MUITO BOM":
                    indexCapacidadeEntregaEquipe = 0;
                    break;

                case "BOM":
                    indexCapacidadeEntregaEquipe = 1;
                    break;

                case "MÉDIO":
                    indexCapacidadeEntregaEquipe = 2;
                    break;

                case "POBRE":
                    indexCapacidadeEntregaEquipe = 3;
                    break;

                default:
                    break;
            }

            return indexCapacidadeEntregaEquipe;
        }

        public static int? RetornarIndiceApoioAltaGestao(string strApoioAltaGestao)
        {
            int? indexApoioAltaGestao = null;

            switch (strApoioAltaGestao.ToUpper())
            {
                case "APOIO FORMAL E TOTAL":
                    indexApoioAltaGestao = 0;
                    break;

                case "DESEJAM O SUCESSO":
                    indexApoioAltaGestao = 1;
                    break;

                case "NEUTRO":
                    indexApoioAltaGestao = 2;
                    break;

                case "RELUTANTES":
                    indexApoioAltaGestao = 3;
                    break;
                default:
                    break;
            }

            return indexApoioAltaGestao;
        }


        public static int? RetornarIndiceEsforcoAdicional(string strEsforcoAdicional)
        {
            int? indexEsforcoAdicional = null;

            switch (strEsforcoAdicional.ToUpper())
            {
                case "ATÉ 10%":
                    indexEsforcoAdicional = 0;
                    break;

                case "ENTRE 11% A 20%":
                    indexEsforcoAdicional = 1;
                    break;

                case "ENTRE 21% E 40%":
                    indexEsforcoAdicional = 2;
                    break;

                case "ACIMA DE 40%":
                    indexEsforcoAdicional = 3;
                    break;

                default:
                    break;
            }

            return indexEsforcoAdicional;
        }
    }

    /* alta probalideade de sucesso de 7 a 14
     * 15 a 17 - sucesso preocupante
     * acima de 17 - probabilidade de insucesso 
     */

    /* de 0 a 99 meses */ /*integers */

    /* VALIDAÇÃO 
     * 1 E 2 MESES = 1.
     * ENTRE 3 E 4 = 2
     * ENTRE 5 A 8 = 3
     * > 8 = 4 */


    /*EQUAÇÃO:  DICE = D + (2 * I) + (2 * C1) + C2 + E;
     * 
     * {
     *  D = DURAÇÃO;
     *  E = ESFORÇO ADICIONAL;
     *  I = CAPACIDADE DE ENTREGA;
     *  C1 = APOIO DA ALTA GESTÃO;
     *  C2 = APOIO DOS STEAKEHOLDERS.
     * }
     * */
}
