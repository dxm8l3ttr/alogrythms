using Algorythms.Core;

namespace Algorythms.Tests;

public class ExtensionTest
{
    [Fact]
    public void Test1()
    {
        var actualList = new List<int>();
        var expectedList = new List<int>
        {
            0, 1, 2, 3, 4, 5
        };
        foreach (var i in ..5)
        {
            actualList.Add(i);
        }
        Assert.Equal(expectedList, actualList);
    }
}