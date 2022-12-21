using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientesJson.interfaces;

namespace ClientesJson.entity
{
    internal class Fornecedor : Cliente
    {
        public string Cnpj { get;set; }
    }
}
