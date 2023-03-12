

// ReSharper disable once CheckNamespace
namespace MSTestProject1;

public partial class Dummy
{
    [TestInitialize]
    public void Initialization()
    {

    }

    /// <summary>
    /// Perform any initialize for the class
    /// </summary>
    /// <param name="testContext"></param>
    [ClassInitialize()]
    public static void ClassInitialize(TestContext testContext)
    {
        TestResults = new List<TestContext>();
    }

}