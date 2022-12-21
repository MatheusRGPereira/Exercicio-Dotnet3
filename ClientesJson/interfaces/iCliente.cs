using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesJson.interfaces
{
    internal interface iCliente
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Documento { get; set; }
        string Tipo { get; set; }
    }
}
