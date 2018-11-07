using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjetoFinal.Models
{
    //CLASSE LOGIN USUARIO
    public class Usuario
    {
        //PROPS PARA CADASTRO DE USUARIO
        //CAMPOS OBRIGATORIOS E REQUIREDS
        public int Id_Usuario { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string Nome_Usuario { get; set; }

        [Required(ErrorMessage = "A idade é obrigatória!")]
        [Range(18,70,ErrorMessage ="A idade mínima é de 18 e máxima 70 anos!")]
        public int Idade_Usuario { get; set; }

        [Required(ErrorMessage = "O Login é obrigatório!")]
        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage ="Somente letras e mínimo 5 e máximo 15 caracteres")]
        [Remote("LoginUnico","Usuario",ErrorMessage ="Esse login já está cadastrado!")]
        public string Login_Usuario { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório!")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um E-mail válido!")]
        [Remote("EmailUnico", "Usuario", ErrorMessage = "Esse email já está cadastrado!")]
        public string Email_Usuario { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória!")]
        [StringLength(12,MinimumLength =4,ErrorMessage = "A Senha deve ter mínima 4 e máxima 12 caracteres!")]
        public string Senha_Usuario { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha_Usuario",ErrorMessage ="As senhas são diferentes!")]
        public string ConfSenha_Usuario { get; set; }

    }
}