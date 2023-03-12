using System.Text;
using DataLibrary.Classes;
using DataLibrary.Data;
using MSTestProject1.Base;
using TeamLibrary.Extensions;
using TeamLibrary.HelperClasses;
using UnitTestHelperLibrary;

namespace MSTestProject1;

[TestClass]
public partial class UnitTest1 : TestBase
{
    [TestMethod]
    [TestTraits(Trait.StringHelpers)]
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

    [TestMethod]
    [TestTraits(Trait.GenericMath)]
    public void GenericMath()
    {
        Assert.AreEqual(10.GetMaxNumber(2),10);
    }

    [TestMethod]
    [TestTraits(Trait.TimeOnly)]
    public void TimeOnlyTest()
    {
        // arrange
        TimeOnly time = new TimeOnly(13, 15, 0);

        // act
        var (_, minute, _) = time.TimeSegments();

        // assert
        Assert.AreEqual(15, minute);
    }

    [TestMethod]
    [TestTraits(Trait.TimeOnly)]
    public void IntersperseList()
    {
        List<string> words = new() { "foo", "bar", "cat" };

        Console.WriteLine(words.Intersperse("-").ToList().Flatten());
        Console.WriteLine(string.Join("-", words));
    }

    [TestMethod]
    [TestTraits(Trait.EntityFrameworkCore)]
    public void EvaluatingWeekendDatesInDatabase()
    {
        // arrange
        const int expectedCount = 3;
        using var context = new StoreContext();
        
        // act
        var saturdayOrSundayDelivered = context.Orders.AsEnumerable().Where(o => o.DeliveredDate.IsWeekend()).ToList();

        // assert
        int count = saturdayOrSundayDelivered.Count;
        
        Assert.AreEqual(saturdayOrSundayDelivered.Count, expectedCount, 
            $"Expect {expectedCount} but returned {count}");
    }

}