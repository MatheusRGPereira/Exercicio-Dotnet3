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
        public static void CadastrarCliente(iCliente iCliente, List<iCliente> listaCliente , string nomeParaUsuario, string documento)
        {
            Console.Clear();
            iCliente.Id = DateTime.Now.Microsecond;
            Console.WriteLine($"Digite o {nomeParaUsuario} do cliente");
            iCliente.Nome = Console.ReadLine();
            Console.WriteLine($"Digite o {documento} do cliente");
            iCliente.Documento = Console.ReadLine();
            listaCliente.Add(iCliente);
        }
        public static void SerializarClientes(iCliente iCliente, string path)
        {
            string jsonString = JsonSerializer.Serialize(iCliente);
            using StreamWriter file = new StreamWriter(path, append:true);
            file.WriteLine(jsonString); 
        }

        public static void LerArquivos(string path, List<iCliente> listaCliente )
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                listaCliente = JsonSerializer.Deserialize<List<iCliente>>(json);
            }
            foreach(var cliente in listaCliente)
            {
                Console.WriteLine(cliente.Nome);
            }
            
        }

    }
}
