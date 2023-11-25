using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SimpleLogin
{
    internal class CadastroUsuarios
    {
        private static Usuarios[] usuarios =
        {
            new Usuarios(){Nome = "Teste", Senha = "123"},
            new Usuarios(){Nome = "POOTest", Senha = "21POO"},
        };
        
        public static void AdicionarUsuario(string nome,  string senha, string nomeCompleto)
        {
            Usuarios[] novoArray = new Usuarios[usuarios.Length + 1];
            for (int i = 0; i < usuarios.Length; i++)
            {
                novoArray[i] = usuarios[i];
            }

            novoArray[novoArray.Length - 1] = new Usuarios() { Nome = nome, Senha = senha, NomeCompleto = nomeCompleto};

            usuarios = novoArray;
        }

        private static Usuarios _usuarioLogado = null;

        public static Usuarios UsuarioLogado
        {
            get { return _usuarioLogado; }
            private set { _usuarioLogado = value;}
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuarios usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha) 
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
