using Common;

Walker w = new Walker();
w.Traverse(".", (fi) => 
{ 
    Console.WriteLine("{0}: {1}, {2}", fi.Name, fi.Length, fi.CreationTime); 
    return true;
});
