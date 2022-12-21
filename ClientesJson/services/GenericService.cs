using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientesJson.entity;
using ClientesJson.interfaces;

namespace ClientesJson.services
{
    internal class GenericService
    {
        public static void CadastrarCliente(iCliente iCliente, List<iCliente> clienteLista, string nomeParaUsuario, string documento)
        {
            Console.Clear();
            iCliente.Id = DateTime.Now.Microsecond;
            Console.WriteLine($"Digite o {nomeParaUsuario} do cliente");
            iCliente.Nome = Console.ReadLine();
            Console.WriteLine($"Digite o {documento} do cliente");
            iCliente.Documento = Console.ReadLine();
            clienteLista.Add(iCliente);
            Console.Clear();
        }
        public static void SerializarClientes(iCliente iCliente, string path)
        {
            string jsonString = JsonSerializer.Serialize(iCliente);
            using StreamWriter file = new StreamWriter(path, append:true);
            file.WriteLine(jsonString); 
        }

        public static void LerArquivo(string path)
        {
            Console.Clear();
            Console.WriteLine("                                               Lista de Clientes Cadastrados\n");
            using (StreamReader r = new StreamReader(path))
            {
                string json;
                while ((json = r.ReadLine()) != null)
                 { 
                    var cliente = JsonSerializer.Deserialize<Cliente>(json);
                    Console.WriteLine($"                               | Id: {cliente.Id} | Nome:{cliente.Nome} | Documento: {cliente.Documento} | Tipo: {cliente.Tipo} |");
                    Console.WriteLine("                           ---------------------------------------------------------------------");
                }
            }
        }

    }
}
