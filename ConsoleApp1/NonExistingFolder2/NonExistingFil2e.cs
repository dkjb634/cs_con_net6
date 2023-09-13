using LanguageExt;

public class NonExistingFil2e
{
    public void foo()
    {
        

        Aff<Unit> a1 = default;
        Aff<Unit> a2 = default;
        Aff<Unit> a3 = default;
        Aff<Unit> a4 = default;
        Aff<Unit> a5 = default;

        _ = (a1, a2, a3, a4, a5).Sequence();

        Console.WriteLine("Hello, World!");
    }
}