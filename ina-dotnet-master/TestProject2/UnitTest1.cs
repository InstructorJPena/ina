using Microsoft.VisualStudio.TestTools.UnitTesting;
using INADevOps2;
namespace TestProject2
{
    [TestClass]
    public class PruebasTransformador
    {
        [TestMethod]
        public void PruebaTransformarBasico()
        {
            // Arrange, acomodar
             Program p = new Program();
            string dato = "ejemplo";

            //Act, actuar
            p.Transformar(dato);
            
            // Assert, verificar
            Assert.AreEqual("EJEMPLO", p.Transformado);
        }
    }
}
