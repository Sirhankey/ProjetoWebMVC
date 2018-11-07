using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class Bd_Login
    {
        public Collection<string> Login { get; set; }
        public Collection<string> Email { get; set; }

        public Bd_Login()
        {
            BdLogin();
            BdEmail();
        }

        void BdLogin()
        {
            Login = new Collection<string>
            {
            "Daniel",
            "Thiago",
            "Mariana"
            };
        }
        void BdEmail()
        {
            Email = new Collection<string>
            {
            "dvmguimaraes@gmail.com",
            "guimaraes189@hotmail.com",
            "marianac-w@gmail.com"
            };
        }

    }
}