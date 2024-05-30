namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestAddNegativeNumbers()
    {
        Assert.Equal(-4L, Add.Eval(-1L, -3L));
    }
    [Fact]
    public void TestAddZero()
    {
        Assert.Equal(10L, Add.Eval(10L, 0L));
    }
    [Fact]
    public void TestMultiply()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestMultiplyNegativeNumbers()
    {
        Assert.Equal(-6L, Multiply.Eval(-2L, 3L));
    }

    [Fact]
    public void TestMultiplyZero()
    {
        Assert.Equal(0L, Multiply.Eval(10L, 0L));
    }
    [Fact]
    public void TestMultiplyLargeNumbers()
    {
        Assert.Equal(150000000L, Multiply.Eval(3000L, 50000L));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(2, Subtract.Eval(5, 3));
    }
    [Fact]
    public void TestSubtractNegativeNumbers()
    {
        Assert.Equal(-2, Subtract.Eval(-5, -3));
    }
    [Fact]
    public void TestSubtractZero()
    {
        Assert.Equal(5, Subtract.Eval(5, 0));
    }
    [Fact]
    public void TestSubtractPrecisionIssue()
    {
        Assert.Equal(0.3f, Subtract.Eval(0.5f, 0.2f));
    }
    [Fact]
    public void TestOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
}