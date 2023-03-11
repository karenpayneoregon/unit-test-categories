using TeamLibrary.Extensions;
using TeamLibrary.HelperClasses;
using UnitTestHelperLibrary;

namespace NUnitTestProject1;

public class Tests
{
    

    [SetUp]
    public void Setup()
    {
    }

    [Test, Category(nameof(Trait.StringHelpers))]
    public void NaturalStringSort()
    {
        // arrange
        List<string> fileNames = new()
        {
            "Example12.txt", "Example1.txt", "Example2.txt", "Example3.txt", "Example4.txt", "Example10.txt"
        };
        List<string> expected = new()
        {
            "Example1.txt", "Example2.txt", "Example3.txt", "Example4.txt", "Example10.txt", "Example12.txt"
        };

        // act
        fileNames.Sort(new NaturalStringComparer());

        // assert
        CollectionAssert.AreEquivalent(fileNames, expected);

    }

    [Test, Category(nameof(Trait.GenericMath))]
    public void GenericMath()
    {
        // arrange
        const int actual = 10;

        // act-assert
        Assert.AreEqual(actual, 10.GetMaxNumber(2));
    }

    [Test, Category(nameof(Trait.TimeOnly))]
    public void TimeOnlyTest()
    {
        // arrange
        const int actual = 15;
        TimeOnly time = new TimeOnly(13, 15, 0);

        // act
        var (_, minute, _) = time.TimeSegments();

        // assert
        Assert.AreEqual(actual, minute);

    }
}