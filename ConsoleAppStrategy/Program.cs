using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;

namespace ConsoleAppStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Pattern Strategy");
            Initialize();
        }

        private static void Initialize()
        {
            GerenciaComissao gerenciaComissao = new GerenciaComissao();

            List<Vendedor> vendedores = new List<Vendedor>();
            vendedores.Add(new Vendedor { Name = "José", TipoVendedor = TipoVendedor.Pleno });
            vendedores.Add(new Vendedor { Name = "Maria", TipoVendedor = TipoVendedor.Junior });
            vendedores.Add(new Vendedor { Name = "Sheila", TipoVendedor = TipoVendedor.Pleno });
            vendedores.Add(new Vendedor { Name = "Alexa", TipoVendedor = TipoVendedor.Junior });

            decimal valorVenda = 400;

            foreach(var v in vendedores)
            {
                Console.WriteLine(string.Format("Total da venda do vendedor {0} foi {1}, com a comissão ficou {2}", v.Name, valorVenda, gerenciaComissao.ApplyCommisssion(v, valorVenda)));
            }

            Console.ReadKey();
        }
    }
}
