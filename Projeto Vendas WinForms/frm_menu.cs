using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_WinForms
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_cad_produto_Click(object sender, EventArgs e)
        {
            var frm = new frm_cadastro_produtos();
            frm.Show();
        }

        private void btn_cad_categoria_Click(object sender, EventArgs e)
        {
            var frm = new frm_cadastro_categoria();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm_cadastro_produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm_cadastro_categoria();
            frm.Show();
        }
    }
}
