using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange 
            SumaController sumaController = new SumaController();
            int a = 5;
            int b = 8;
            int esperado = 13;

            //Act
            int resultado = sumaController.Add(a, b);

            //Assert
            Assert.AreEqual(esperado, resultado);


        }
        public void TestMultiply()
        {
            //Arrange 
            SumaController sumaController = new SumaController();
            int a = 3;
            int b = 5;
            int esperado = 15;

            //Act
            int resultado = sumaController.Multiply(a, b);

            //Assert
            Assert.AreEqual(esperado, resultado);


        }
    }
}
