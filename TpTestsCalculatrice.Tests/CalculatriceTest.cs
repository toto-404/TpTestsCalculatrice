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

    [TestMethod]
    public void Multiplication_Retourne12_Si4Fois3()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Multiplication(4, 3);
        Assert.AreEqual(12, resultat);
    }

    [TestMethod]
    public void Division_Retourne5_Si10Divise2()
    {
        Calculatrice calc = new Calculatrice();
        double resultat = calc.Division(10, 2);
        Assert.AreEqual(5, resultat);
    }

    [TestMethod]
    public void Division_LanceException_SiDivisionParZero()
    {
        Calculatrice calc = new Calculatrice();
        Assert.Throws<Exception>(() =>
        {
            calc.Division(10, 0);
        });
    }

    [TestMethod]
    public void EstPair_RetourneTrue_SiNombrePair()
    {
        Calculatrice calc = new Calculatrice();
        bool resultat = calc.EstPair(4);
        Assert.IsTrue(resultat);
    }
    
    [TestMethod]
    public void EstPair_RetourneFalse_SiNombreImpair()
    {
        Calculatrice calc = new Calculatrice();
        bool resultat = calc.EstPair(5);
        Assert.IsFalse(resultat);
    }

    [TestMethod]
    public void Addition_RetourneZero_Si0Plus0()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Addition(0, 0);
        Assert.AreEqual(0, resultat);
    }

    [TestMethod]
    public void Addition_RetourneZero_SiNombreNegatif()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Addition(-1, 1);
        Assert.AreEqual(0, resultat);
    }

    [TestMethod]
    public void Addition_DeuxGrandsNombres_RetourneSomme()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Addition(100, 200);
        Assert.AreEqual(300, resultat);
    }

    //partie bonus
    [TestMethod]
    public void Max_Retourne7_Si3Et7()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Max(7, 3);
        Assert.AreEqual(7, resultat);
    }

    [TestMethod]
    public void Max_Retourne10_Si10Et2()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Max(10, 2);
        Assert.AreEqual(10, resultat);
    }

    [TestMethod]
    public void Max_Retourne5_Si5Et5()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Max(5, 5);
        Assert.AreEqual(5, resultat);
    }
}
