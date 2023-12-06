using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Cliente : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public string IdCli { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string CPF { get; set; }
    }
}
