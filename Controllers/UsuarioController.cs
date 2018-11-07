using ProjetoFinal.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoFinal.Controllers
{
    public class UsuarioController : Controller
    {
        Bd_Login bancoDados = new Bd_Login();
        JoKenPo game = new JoKenPo();

        // GET: Usuario
        public ActionResult Index()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        //RETORNA VIEW USUARIO CADASTRADO
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            //INFORMA NO ValidationSummary SE AS SENHAS SAO IGUAIS
            if(usuario.Senha_Usuario != usuario.ConfSenha_Usuario)
            {
                ModelState.AddModelError("", "As senhas são diferentes!");
            }

            //VERIFICA REQUISICAO DO USUARIO
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        //RETORNA VIEW USUARIO
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        //VERIFICA LOGIN EXISTENTE
        public ActionResult LoginUnico(string Login_Usuario)
        {
            return Json(bancoDados.Login.All(x => x.ToLower() != Login_Usuario.ToLower()), JsonRequestBehavior.AllowGet);
        }
        public ActionResult EmailUnico(string Email_Usuario)
        {
            return Json(bancoDados.Email.All(x => x.ToLower() != Email_Usuario.ToLower()), JsonRequestBehavior.AllowGet);
        }


        public ActionResult JoKenPo(JoKenPo model)
        {
            
            return View(model); // return the view with modified model
        }

        public ActionResult Creditos()
        {
            return View();
        }

    }
}