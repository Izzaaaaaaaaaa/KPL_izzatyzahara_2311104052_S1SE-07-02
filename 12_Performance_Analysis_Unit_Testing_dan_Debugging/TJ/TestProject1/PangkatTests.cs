using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TJMod12_2311104052;

[TestClass]
public class PangkatTests
{
    [TestMethod]
    public void TestPangkatB0()
    {
        Assert.AreEqual(1, Form1.CariNilaiPangkat(0, 0));
    }

    [TestMethod]
    public void TestPangkatNegatif()
    {
        Assert.AreEqual(-1, Form1.CariNilaiPangkat(5, -2));
    }

    [TestMethod]
    public void TestBesarDari10()
    {
        Assert.AreEqual(-2, Form1.CariNilaiPangkat(5, 11));
    }

    [TestMethod]
    public void TestLebih100()
    {
        Assert.AreEqual(-2, Form1.CariNilaiPangkat(101, 3));
    }

    [TestMethod]
    public void TestOverflow()
    {
        Assert.AreEqual(-3, Form1.CariNilaiPangkat(9, 30));
    }

    [TestMethod]
    public void TestNormal()
    {
        Assert.AreEqual(27, Form1.CariNilaiPangkat(3, 3));
    }
}
