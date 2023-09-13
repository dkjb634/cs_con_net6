using System.Collections;
using System.Diagnostics;
using ConsoleApp1.AnotherFOlder;
using JetBrains.Annotations;

namespace ConsoleApp1;

public interface Iasds_jopa
{
    
}
public  class DataObject
{
    
#if SOME_DEFINE
        private void DoABC()
        {

        }
#endif

    
    public String Name { get; set; }
    
    public void GetSomething([PathReference] eeeAuthoring obj)
    {
        const string name = "Foo";
        Console.WriteLine(name);
        
    }
}