using BL.STORE.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace BL.Store.Testes.UI.Controllers
{
    [TestClass, TestCategory("Controllers/HomeController")] //para entender que a classe é de testes
    public class HomeControllerTest
    {
        // dado o HomeCOntroller
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            //arrange -> estrutura do teste
            var homeController = new HomeController();


            //act -> ação 
            var result = homeController.Index();

            //assert -> se é o resultado esperado
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
