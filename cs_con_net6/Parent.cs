namespace cs_con_net6;

public class Parent
{
    protected static bool Equal(Parent a, int b)
    {
        return a.a == b;//
    }
    protected bool Equals(Parent other)
    {
        return a == other.a && b == other.b;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Parent)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(a, b);
    }

    readonly protected int a;
    readonly protected int b;
    public static bool operator ==(Parent aa, Parent bb) => Equal(aa, bb.a);
    public static bool operator !=(Parent aa, Parent bb) => Equal(aa, bb.b);
}