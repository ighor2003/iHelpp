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
    public partial class FrmTrabalhador : Form
    {
        public FrmTrabalhador()
        {
            InitializeComponent();
        }

        private void FrmTrabalhador_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            {
                Trabalhador trabalhador = new Trabalhador();

                trabalhador.Nome = txtNameTrabalhador.Text;
                trabalhador.Email = txtEmailTrabalhador.Text;
                trabalhador.Senha = txtSenhaTrabalhador.Text;
                trabalhador.Cep = txtSenhaTrabalhador.Text;
                trabalhador.Cpf = txtSenhaTrabalhador.Text;
                trabalhador.Celular = txtSenhaTrabalhador.Text;
                trabalhador.Telefone = txtSenhaTrabalhador.Text;
                trabalhador.Inserir();

                MessageBox.Show("Trabalhador inserido com Sucesso!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Informe um ID valido para o Trabalhador ser Alterado!");
                }
                else
                {
                    Trabalhador trabalhador = new Trabalhador();
                    trabalhador.Nome = txtNameTrabalhador.Text;

                    if (trabalhador.Alterar(int.Parse(txtId.Text)))
                    {
                        MessageBox.Show("Trabalhador alterado com Sucesso!");
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
                listBoxTrabalhador.Items.Clear();
                Trabalhador trabalhador = new Trabalhador();
                List<Trabalhador> lista = trabalhador.Listar();
                foreach (var cat in lista)
                {
                    listBoxTrabalhador.Items.Add(cat.Nome);
                }
            }
        }

        private void btnLimparTrab_Click(object sender, EventArgs e)
        {
            listBoxTrabalhador.Items.Clear();
        }
    }

    
}
