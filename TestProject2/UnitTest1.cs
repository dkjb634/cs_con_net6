namespace TestProject2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
	    throw new FileLoadException("TestMessage");
        Assert.Pass();
        //TODO: qweq
    }
}