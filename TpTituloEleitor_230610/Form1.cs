using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpTituloEleitor_230610
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja limpar?", "Limpando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                txtNinscricao.Clear();
                txtNinscricao.Focus();
                lblResultado.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (validaTitulo.ValidaTitulo(txtNinscricao.Text , label2) == true)
            {
                lblResultado.Text = "Titulo Correto";
            }
            else
            {
                lblResultado.Text = "Titulo Incorreto";
            }
        }
    }
}
