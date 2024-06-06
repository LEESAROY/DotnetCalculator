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
    [Fact]
    public void TestExitOperation()
    {
        var exitInput = new StringReader("4\n");
        Console.SetIn(exitInput);
        var exitOperationProcess = new System.Diagnostics.Process();
        exitOperationProcess.StartInfo.FileName = "dotnet";
        exitOperationProcess.StartInfo.Arguments = "run";
        exitOperationProcess.StartInfo.UseShellExecute = false;
        exitOperationProcess.StartInfo.RedirectStandardInput = true;
        exitOperationProcess.Start();
        exitOperationProcess.WaitForExit();
        Assert.True(exitOperationProcess.HasExited);

    }

    [Fact]
    public void TestContinueFunction()
    {
        var continueInput = new StringReader("1\n10\n4\n4\nno\n");
        Console.SetIn(continueInput);
        var continueFunctionProcess = new System.Diagnostics.Process();
        continueFunctionProcess.StartInfo.FileName = "dotnet";
        continueFunctionProcess.StartInfo.Arguments = "run";
        continueFunctionProcess.StartInfo.UseShellExecute = false;
        continueFunctionProcess.StartInfo.RedirectStandardInput = true;
        continueFunctionProcess.Start();
        continueFunctionProcess.WaitForExit();
        Assert.True(continueFunctionProcess.HasExited);
    }
    [Fact]
    public void TestValidOperation()
    {
        var validInput = new StringReader("5\n1\n10\n5\n3\n4\nno\n");
        Console.SetIn(validInput);
        var validOperationProcess = new System.Diagnostics.Process();
        validOperationProcess.StartInfo.FileName = "dotnet";
        validOperationProcess.StartInfo.Arguments = "run";
        validOperationProcess.StartInfo.UseShellExecute = false;
        validOperationProcess.StartInfo.RedirectStandardInput = true;
        validOperationProcess.Start();
        validOperationProcess.WaitForExit();
        Assert.True(validOperationProcess.HasExited);
    }
}