using Common;

namespace Common.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Walker w = new Walker();
        w.Traverse(".", (fi) => 
        { 
            Console.WriteLine("{0}: {1}, {2}", fi.Name, fi.Length, fi.CreationTime); 
            return true;
        });
    }
}