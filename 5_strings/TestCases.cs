namespace _5_strings;

public class StringTests
{
    [Fact]
    public void ConvertToUpperTest()
    {
        var implementation = new Implementation();
        Assert.Equal("HELLO WORLD", implementation.ConvertToUpper("hello world"));
    }

    [Fact]
    public void ConvertToLowerTest()
    {
        var implementation = new Implementation();
        Assert.Equal("hello world", implementation.ConvertToLower("HELLO WORLD"));
    }

    [Fact]
    public void FindIndexTest()
    {
        var implementation = new Implementation();
        Assert.Equal(4, implementation.FindIndex("apple", 'e'));
        Assert.Equal(-1, implementation.FindIndex("banana", 'z'));
    }

    [Fact]
    public void GetFirstAndLastCharTest()
    {
        var implementation = new Implementation();
        Assert.Equal("at", implementation.GetFirstAndLastChar("apple"));
        Assert.Equal("", implementation.GetFirstAndLastChar(""));
    }

    [Fact]
    public void GetSubstringTest()
    {
        var implementation = new Implementation();
        Assert.Equal("world", implementation.GetSubstring("hello world", 6));
    }
}