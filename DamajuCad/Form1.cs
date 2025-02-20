using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DamajuCad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CadLanche_Click(object sender, EventArgs e)
        {
            CadLanche form = new CadLanche();
            form.ShowDialog();
          
        }

        private void GerenciamentoLanche_Click(object sender, EventArgs e)
        {
            gerenciarProd form = new gerenciarProd();
            form.ShowDialog();
        }

        private void CadCliente_Click(object sender, EventArgs e)
        {
            CadCliente2 form = new CadCliente2();
            form.ShowDialog();
        }

        private void GerenciamentoCliente_Click(object sender, EventArgs e)
        {
            gerenciarCli form = new gerenciarCli();
            form.ShowDialog();
        }
    }
}
