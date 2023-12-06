using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class OrdemServico : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true, AutoIncrement = true)]
        public string IdSer { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public string IdProd { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public string IdCli { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime DataOrdemServico { get; set; }
    }
}
