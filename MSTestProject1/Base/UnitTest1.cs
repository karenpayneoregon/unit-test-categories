using DataLibrary.Data;

// ReSharper disable once CheckNamespace
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
        if (TestContext.TestName != nameof(EvaluatingWeekendDatesInDatabase)) return;
        using var context = new StoreContext();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }
}

