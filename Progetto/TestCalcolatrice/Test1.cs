namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalcolatriceLib.Calcolatrice calcolatrice = new CalcolatriceLib.Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, 0.0001, "La somma di 2 e 3 dovrebbe essere 5");
        }
        [TestMethod]
        public void TestSommaCon0()
        {
            CalcolatriceLib.Calcolatrice calcolatrice = new CalcolatriceLib.Calcolatrice();
            double risultato = calcolatrice.Somma(0, 0);
            Assert.AreEqual(0, risultato, 0.0001, "La somma di 0 e 0 dovrebbe essere 0");
        }
    }
}
