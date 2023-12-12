namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        const decimal value = 279.98M;
        var cents = value.ToCents();

        Assert.AreEqual(27998, cents);
    }
}