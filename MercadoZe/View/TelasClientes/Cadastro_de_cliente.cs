using MercadoZe.Controller;
using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoZe.View.TelasClientes
{
    public partial class Cadastro_de_cliente : Form
    {
        public Cadastro_de_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes.NomeCliente = tbx_nomeCliente.Text;
            Clientes.FoneCliente = tbx_nomeCliente.Text;
            Clientes.EmailCliente = tbx_foneCliente.Text;

            Manipulacliente manipulacliente = new Manipulacliente();
            manipulacliente.AdicionaCliente();
        }
    }
}
