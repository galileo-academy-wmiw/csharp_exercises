namespace _4_numbers_and_operators;

public class NumbersAndOperatorsTests
{
    [Fact]
    public void UserInputTest()
    {
        var implementation = new Implementation();
        var result = implementation.GetUserInput("Alice");
        Assert.Equal("Hallo, Alice!", result);
    }

    [Fact]
    public void AbsoluteValueTest()
    {
        var implementation = new Implementation();
        Assert.Equal(80, implementation.GetAbsoluteValue(-80));
    }

    [Fact]
    public void SquareRootTest()
    {
        var implementation = new Implementation();
        Assert.Equal(9, implementation.GetSquareRoot(81));
    }

    [Fact]
    public void FloorTest()
    {
        var implementation = new Implementation();
        Assert.Equal(4, implementation.GetFlooredValue(4.9));
    }

    [Fact]
    public void MinimumTest()
    {
        var implementation = new Implementation();
        Assert.Equal(3, implementation.GetMinimum(3, 10));
    }

    [Fact]
    public void AddTest()
    {
        var implementation = new Implementation();
        Assert.Equal(15, implementation.Add(10, 5));
    }

    [Fact]
    public void SubtractTest()
    {
        var implementation = new Implementation();
        Assert.Equal(5, implementation.Subtract(10, 5));
    }

    [Fact]
    public void ModuloTest()
    {
        var implementation = new Implementation();
        Assert.Equal(1, implementation.Modulo(10, 3));
    }

    [Fact]
    public void FormatStringTest()
    {
        var implementation = new Implementation();
        var result = implementation.FormatString("Bob", 30);
        Assert.Equal("Naam: Bob, Leeftijd: 30", result);
    }

    [Fact]
    public void ApplyShortcutsTest()
    {
        var implementation = new Implementation();
        Assert.Equal(3, implementation.OperatorShortcuts(4));
    }
}
