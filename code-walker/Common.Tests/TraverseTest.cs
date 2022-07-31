using Common;

namespace Common.Tests;

public class TraverseTest
{
    [Fact]
    public void WalkFromRoot()
    {
        Walker w = new Walker();
        w.Traverse(".", (fi) => 
        { 
            Console.WriteLine("{0}: {1}, {2}", fi.Name, fi.Length, fi.CreationTime); 
            return true;
        });
    }

    
}