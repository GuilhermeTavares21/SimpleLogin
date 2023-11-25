using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLogin
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioCadastro = txtUsuarioCadastro.Text;
            string usuarioSenha = txtSenhaCadastro.Text;
            string usuarioConfirmar = txtConfirm.Text;
            string nomeCompleto = txtNomeCompleto.Text;


            if (usuarioCadastro == "" || usuarioSenha == "" || usuarioConfirmar == "" ) 
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            if (usuarioSenha == usuarioConfirmar)
            {
                CadastroUsuarios.AdicionarUsuario(usuarioCadastro, usuarioSenha, nomeCompleto);
                MessageBox.Show("Usuário Cadastro");
                this.Close();
            } else
            {
                MessageBox.Show("Senhas estão diferentes");
                return;
            }

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
