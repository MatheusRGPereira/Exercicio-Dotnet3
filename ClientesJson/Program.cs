﻿

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text.Json;
using ClientesJson.entity;
using ClientesJson.interfaces;
using ClientesJson.services;

internal class Program
{
    private static void Main(string[] args)
    {
        List <iCliente> clienteLista = new List<iCliente>();
        List<Cliente> clienteDeserializado = new List<Cliente>();
        var path = @"C:\\Users\\I\\source\\repos\\ClientesJson\\ClientesJson\\exports\\clientes.json";
        bool menu = true;

        while (menu)
        {
            Console.WriteLine("======= Bem vindo ao Menu =======");
            Console.WriteLine("""
                Digite a opção desejada
                1- Cadastrar Usuario Juridico
                2- Cadastrar Usuario Fisico
                3- Salvar os dados dos clientes
                4- Listar Usuarios Cadastrados
                5- sair
            """);
            int escolhaUsuario = int.Parse(Console.ReadLine());
            switch (escolhaUsuario)
            {
                case 1:
                    var fornecedor = new Fornecedor() {Tipo = "J" };
                    GenericService.CadastrarCliente(fornecedor, clienteLista , "Nome Fantasia", "Cnpj");
                    break;

                case 2:
                    var usuario = new Usuario() {Tipo = "F"};
                    GenericService.CadastrarCliente(usuario, clienteLista, "Nome", "Cpf" );
                    break;
                case 3:
                    GenericService.SerializarClientes( clienteLista, path);
                    break;
                case 4:
                    GenericService.LerArquivos(path, clienteDeserializado);
                    break;

                case 5:
                    Console.WriteLine("Obrigada por utilizar nossos serviços");
                    Thread.Sleep(5000);
                    menu = false;
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                     break;
            }

        }



    }
 
}