﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Fornecedor : BaseModel
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /*EF Relations*/
        public IEnumerable<Produto> Produtos { get; set; }

    }
}