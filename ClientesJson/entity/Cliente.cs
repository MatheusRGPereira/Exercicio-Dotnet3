using ClientesJson.interfaces;

namespace ClientesJson.entity
{
    internal class Cliente : iCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Tipo { get; set; }
    }

}
