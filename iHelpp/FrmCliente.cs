using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iHelp.Classes;
using iHelpp.Classes;

namespace iHelpp
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBoxCliente.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            {
                Cliente cliente = new Cliente();

                cliente.Nome = txtNameCliente.Text;
                cliente.Email = txtEmailCliente.Text;
                cliente.Senha = txtSenhaCliente.Text;
                cliente.Inserir();
                //txtIdCliente.Text = cliente.Id.ToString();

                MessageBox.Show("Cliente inserido com Sucesso!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Informe um ID valido para o Cliente ser Alterado!");
                }
                else
                {
                    Cliente cliente= new Cliente();
                    cliente.Nome = txtNameCliente.Text;

                    if (cliente.Alterar(int.Parse(txtId.Text)))
                    {
                        MessageBox.Show("Cliente alterado com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ops... Algo deu Errado! :(");
                    }
                }
            }
        }

        private void bntConsultar_Click(object sender, EventArgs e)
        {
            {
                listBoxCliente.Items.Clear();
                Cliente cliente= new Cliente();
                List<Cliente> lista = cliente.Listar();
                foreach (var cat in lista)
                {
                    listBoxCliente.Items.Add(cat.Nome);
                }
            }
        }
    }
}
