using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamajuCad
{
    public partial class Menu : Form
    {

        bool VerSenhaTxt = false;
        private string UsuarioCorreto = "victor";
        private string SenhaCorreta = "123";

        public Menu()
        {
            InitializeComponent();
            textBoxSenha.PasswordChar = '*';  // senha oculta ao iniciar


            
        }


        private void ocultar_senha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                ocultar_senha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                ocultar_senha.Text = "Mostrar Senha";
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxNome.Text;
            string senha = textBoxSenha.Text;

           

            if
                (usuario == UsuarioCorreto && senha == SenhaCorreta)
            {
                labelMessage.Text = "Login bem-sucedido";
                labelMessage.ForeColor = Color.Green;

                this.Hide(); // vai esconder a tela quando eu entrar no gerenciar 
                

                Form1 form = new Form1();
                form.ShowDialog();
                this.Close(); //  fecha depois que o Form1 for fechado


            }
            else
            {
                labelMessage.Text = "Usuario ou senha invalidos";
                labelMessage.ForeColor = Color.Red;
                textBoxNome.Text = "";
                textBoxSenha.Text = "";
                textBoxNome.Focus();

               
            }
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
