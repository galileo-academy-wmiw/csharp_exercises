namespace _3_data_types_and_variables;

public class DataTypesAndVariableTests
{
    [Fact]
    public void StringTest()
    {
        var implementation = new Implementation();
        var result = implementation.GetStringValue();
        Assert.Equal("Hello, World!", result);
    }

    [Fact]
    public void IntTest()
    {
        var implementation = new Implementation();
        var result = implementation.GetIntValue();
        Assert.Equal(42, result);
    }
}