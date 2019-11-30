using Jose;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JoseUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Organizar

            double cantidadInicial = 1000.00;
            double cantidadRetirada = 450.00;
            double CantidadEsp = 1450.00;
            Company JoseObj = new Company("JoseFer", cantidadInicial);



            //Actuar
            JoseObj.Spend(cantidadRetirada);


            //Verificar
            double cantidad = JoseObj.SaveProject;
            Assert.AreEqual(CantidadEsp, cantidad, 0.001, "Cantidad no Retirada");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Organizar

            double cantidadInicial = 1000.00;
            double CantidadIngresada = 4500.00;
            double CantidadEsp = 5500.00;
            Company JoseObj = new Company("JoseFer", cantidadInicial);



            //Actuar
            JoseObj.Save(CantidadIngresada);


            //Verificar
            double cantidad = JoseObj.SaveProject;
            Assert.AreEqual(CantidadEsp, cantidad, 0.001, "Cantidad no Ingresada");
        }


    }


}
