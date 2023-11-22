using MercadoZe.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Clientes
    {
        private static int Id_Cli;
        private static string nomeCliente;
        private static string foneCliente;
        private static string emailCliente;

        public static int Id_Cli1 { get => Id_Cli; set => Id_Cli = value; }
        public static string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public static string FoneCliente { get => foneCliente; set => foneCliente = value; }
        public static string EmailCliente { get => emailCliente; set => emailCliente = value; }
    }
}
