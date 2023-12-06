using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Estoque : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public string IdProd { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }
    }
}
