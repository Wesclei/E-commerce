using BL.Store.Domain.Contracts.Repositories;
using BL.Store.Domain.Helpers;
using BL.STORE.UI.ViewModels.Conta.Login;
using System.Web.Mvc;
using System.Web.Security;

namespace BL.STORE.UI.Controllers
{
    public class ContaController : Controller
    {
        // instanciar para a classe toda apenas uma vez - readonly
        private readonly IUsuarioRepository _usuarioRepository;

        public ContaController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public ActionResult Login(string returnURL)
        {
            var model = new LoginVM() { ReturnUrl = returnURL };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var usuario = _usuarioRepository.Get(model.Email);
            if (usuario == null)
            {
                ModelState.AddModelError("Email", "E-mail não localizado.");
            }
            else
            {
                if (usuario.Senha != model.Senha.Encrypt())
                    ModelState.AddModelError("Senha", "Senha inválida.");
            }

            if (ModelState.IsValid)
            {
                //Autenticar
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);
                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
                
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        protected override void Dispose(bool disposing) { }
    }
}

//43 MINUTOS