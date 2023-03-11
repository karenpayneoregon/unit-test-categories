namespace MSTestProject1;
public partial class UnitTest1
{
    [ClassInitialize()]
    public static void Initialize(TestContext testContext)
    {
        TestResults = new List<TestContext>();
    }

    [TestInitialize]
    public void Init()
    {
        if (TestContext.TestName == nameof(NaturalStringSort))
        {
            Console.WriteLine("place to do something");
        }
    }
}

