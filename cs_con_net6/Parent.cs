namespace cs_con_net6;

public class Parent
{
    protected readonly int a;
    protected readonly int b;

    
    protected static bool Equal(Parent a, int b)
    {
	    b+=10;
        return a.a == b; //sss
    }

    protected bool Equals(Parent other)
    {
        return a == other.a && b == other.b;
        //Local Change aa
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Parent)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(a, b);
    }

    public static bool operator ==(Parent aa, Parent bb) => Equal(aa, bb.a);
    public static bool operator !=(Parent aa, Parent bb) => Equal(aa, bb.b);
}