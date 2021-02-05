using BL.STORE.UI.Data;
using BL.STORE.UI.Infra.Helpers;
using BL.STORE.UI.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace BL.STORE.UI.Controllers
{
    public class ContaController : Controller
    {
        // instanciar para a classe toda apenas uma vez - readonly
        private readonly BLStoreDataContext _ctx = new BLStoreDataContext();

        [HttpGet]
        public ActionResult Login(string returnURL)
        {
            var model = new LoginVM() { ReturnUrl = returnURL };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var usuario = _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());

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
        protected override void Dispose(bool disposing)
        {
            //Encerra a seção com o banco.
            _ctx.Dispose();
        }
    }
}

//43 MINUTOS