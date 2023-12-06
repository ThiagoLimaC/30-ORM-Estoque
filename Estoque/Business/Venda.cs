using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Venda : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public string IdProd { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public string IdCli { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime DataVenda { get; set; }
    }
}
