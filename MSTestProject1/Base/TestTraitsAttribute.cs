using UnitTestHelperLibrary;

namespace MSTestProject1.Base
{
    /// <summary>
    /// Declarative class for using Trait enum about for traits on test method.
    /// </summary>
    /// <remarks>
    /// https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.testcategoryattribute?view=visualstudiosdk-2022
    /// </remarks>
    public class TestTraitsAttribute : TestCategoryBaseAttribute
    {
        private readonly Trait[] _traits;

        public TestTraitsAttribute(params Trait[] traits)
        {
            _traits = traits;
        }

        public override IList<string> TestCategories => _traits.Select(trait 
            => Enum.GetName(typeof(Trait), trait)).ToList();
    }

}