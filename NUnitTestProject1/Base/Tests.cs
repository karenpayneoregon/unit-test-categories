using DataLibrary.Data;

// ReSharper disable CheckNamespace
namespace NUnitTestProject1;
public partial class Tests
{
    public void CreateDatabase()
    {
        using var context = new StoreContext();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }
}
