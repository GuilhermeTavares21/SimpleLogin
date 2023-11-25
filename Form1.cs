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
    public partial class TelaInicial : Form
    {
        string nomeCompleto;
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public TelaInicial(string nomeCompleto)
        {
            this.nomeCompleto = nomeCompleto;
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            Login f = new Login();
            FormCadastro formCadastro = new FormCadastro();
            
            while (CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();
                 
                if (Login.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }

            label_BoasVindas.Text = "Bem Vindo! \n" + CadastroUsuarios.UsuarioLogado.NomeCompleto;
            Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
