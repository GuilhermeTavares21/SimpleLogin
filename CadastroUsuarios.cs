using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogin
{
    internal class CadastroUsuarios
    {
        private static Usuarios[] usuarios =
        {
            new Usuarios(){Nome = "Teste", Senha = "123"},
            new Usuarios(){Nome = "POOTest", Senha = "21POO"},
        };

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
