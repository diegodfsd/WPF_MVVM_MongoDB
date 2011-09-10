using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFAgenda.Dominio;

namespace WPFAgenda.Tests
{
    [TestClass]
    public class ContatoTests
    {
        [TestMethod]
        public void Quando_Uma_Propriedade_For_Alterada_O_Evento_PropertyChanged_Eh_Disparado()
        {
            var propertyChangedFoiDisparado = false;
            Contato contato = new Contato();
            contato.PropertyChanged += (sender, e) => propertyChangedFoiDisparado = e.PropertyName == "Nome";
            contato.Nome = "Contato";

            Assert.IsTrue(propertyChangedFoiDisparado);
        }

        [TestMethod]
        public void Quando_Uma_Propriedade_Invalida_For_Informada_Como_Alterada_Nao_Deve_Disparar_Exception()
        {
            Contato contato = new Contato();
            contato.VerifyPropertyName("idade");
        }
    }
}
