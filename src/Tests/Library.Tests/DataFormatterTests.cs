namespace Library.Tests;
using NUnit.Framework;
using TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestFormatoCorrecto()
    {
        string testDate = "10/11/1997";
        string Actual = DateFormatter.ChangeFormat(testDate);
        string Expected = "1997-11-10";
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void TestFormatoIncorrecto()
    {
        string testDate = "1997/10/11";
        string Actual = DateFormatter.ChangeFormat(testDate);
        string Expected = "Formato Incorrecto";
        Assert.AreEqual(Actual, Expected);
    }

    [Test]
    public void TestNullDate()
    {
        string testDate = "";
        string Actual = DateFormatter.ChangeFormat(testDate);
        string Expected = "Fecha nula o vacia";
        Assert.AreEqual(Actual, Expected);
    }
}