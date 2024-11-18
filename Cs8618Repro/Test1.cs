namespace Cs8618Repro;

[TestClass]
public sealed class Test1
{
    private TestClass _testClass;
    private TestClass _testClassProp { get; set; }

    [TestInitialize]
    public void Init()
    {
        _testClass = new TestClass();
        _testClassProp = new TestClass();
    }
    
    [TestMethod]
    public void TestMethod1()
    {
    }
}

public class TestClass
{
    
}