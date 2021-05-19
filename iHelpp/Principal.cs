using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iHelpp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicos frmServicos = new FrmServicos();
            frmServicos.MdiParent = this;
            frmServicos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void trabalhadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabalhador frmTrabalhador = new FrmTrabalhador();
            frmTrabalhador.MdiParent = this;
            frmTrabalhador.Show();
        }
    }
}
