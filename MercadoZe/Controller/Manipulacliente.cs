using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class Manipulacliente
    {
        public void AdicionaCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar()); //serve para fazer conexão com o banco.
            SqlCommand cmd = new SqlCommand("P_InserirClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@nomeCliente", Clientes.NomeCliente);
                cmd.Parameters.AddWithValue("@foneCliente", Clientes.FoneCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Clientes.EmailCliente);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso.");
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
