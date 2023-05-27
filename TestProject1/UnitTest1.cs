namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod, TestCategory(nameof(Trait.Local))]
    public void TestMethod1()
    {
    }

    [TestMethod, TestCategory(nameof(Trait.Remote))]
    public void TestMethod2()
    {

    }
}