using TeamLibrary.Extensions;

namespace xUnitTestProject2;

public class UnitTest1
{
    [Fact]
    [Trait("Category", "Generic math")]
    public void Test1()
    {
        Assert.Equal(10, 10.GetMaxNumber(2));
    }
}