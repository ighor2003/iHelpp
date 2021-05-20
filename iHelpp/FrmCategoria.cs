using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iHelpp.Classes;

namespace iHelpp
{
    public partial class FrmCategoria : Form
    {
        private IEnumerable<object> lista;

        public object Nome { get; private set; }

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void bntConsultar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Categoria categoria = new Categoria();
            List<Categoria> lista = categoria.Listar();
            foreach (var cat in lista)
            {
                listBox1.Items.Add(cat.Nome);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = txtName.Text;
            categoria.inserir();
            MessageBox.Show("Categoria inserida com Sucesso!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Informe um ID valido de Categoria para ser Alterado!");
            }
            else
            {
                Categoria categoria = new Categoria();
                categoria.Nome = txtName.Text;

                if (categoria.Alterar(int.Parse(txtId.Text)))
                {
                    MessageBox.Show("categoria alterada com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Ops... Algo deu Errado! :(");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
