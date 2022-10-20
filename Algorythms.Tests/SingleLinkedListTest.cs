namespace Algorythms.Tests;

using Algorythms.Core;

public class SingleLinkedListTest
{
    [Fact]
    public void AddTest()
    {
        var list = new SingleLinkedList<int>();
        
        list.Add(0);
        list.Add(2);
        list.Add(4);
        list.Add(7);
        list.Add(89);
        
        Assert.Equal(5, list.Count);
        Assert.Equal(0, list[0]);
        Assert.Equal(2, list[1]);
        Assert.Equal(4, list[2]);
        Assert.Equal(7, list[3]);
        Assert.Equal(89, list[4]);
    }

    [Fact]
    public void InsertTest()
    {
        var list = new SingleLinkedList<string>();
        list.Add("aboba");
        list.Add("sus");
        list.Add("hohoho");
        list.Insert(2, "among us");
        
        Assert.Equal("among us", list[2]);
    }

    [Fact]
    public void IndexOfTest()
    {
        var list = new SingleLinkedList<int>();
        list.Add(4);
        list.Add(15);
        list.Add(4);
        list.Add(25);
        
        Assert.Equal(0, list.IndexOf(4));
        Assert.Equal(3, list.IndexOf(25));
    }

    [Fact]
    public void RemoveTest()
    {
        var list = new SingleLinkedList<int>();
        list.Add(4);
        list.Add(45);
        list.Add(325);
        list.Add(13515);
        list.Remove(4);
        
        Assert.False(list.Remove(15));
        Assert.Equal(45, list[0]);
    }
}