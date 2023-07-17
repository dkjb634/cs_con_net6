namespace cs_con_net6;

class ParentImpl : Parent
{// From ParentImpl if you generate Equals and GetHashCode via Generate->Overriding members -they are marked as redundant;
    //if generate with quickfix Generate equality members they are not redundant.
    
    public static bool operator ==(ParentImpl left, int right) => left.b == right;
    public static bool operator !=(ParentImpl left, int right) => left.b != right;
    
    //ss

}