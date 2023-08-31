using System.Reflection.Metadata;

namespace cs_con_net6;

public class BinaryParser
{
    private SequencePoint header;

    public FieldKing ParseField(ReadOnlySpan<char> header)
    {
        if (header.SequenceEqual("<==HEADER==>")) return new FieldKing();

        return new FieldKing();
    }
}

public class FieldKing
{
    private BinaryParser Reference;

    public FieldKing foo()
    {
        return Reference.ParseField(new ReadOnlySpan<char>(new[] { 'a', 'b', 'v' }));
    }
}