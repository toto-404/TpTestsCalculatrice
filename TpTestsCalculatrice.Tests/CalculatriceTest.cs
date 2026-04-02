namespace TpTestsCalculatrice.Tests;

[TestClass]
public class CalculatriceTests
{
    [TestMethod]
    public void Addition_Retourne5_Si2Plus3()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Addition(2, 3);
        Assert.AreEqual(5, resultat);
    }
    [TestMethod]
    public void Soustraction_Retourne2_Si5Moins3()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Soustraction(5, 3);
        Assert.AreEqual(2, resultat);
    }
}
