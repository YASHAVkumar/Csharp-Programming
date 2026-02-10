namespace Basic.Application.StructureDemo;
public readonly struct Structure(int x, int y)
{
    private readonly int _x = x;
    private readonly int _y = y;
    public int X { get; init; } = x;
    public int Y { get; init; } = y;

    public Structure() : this(0, 0)
    {
    }
}

public record RecordStruct(int A, int B)
{
    public string? Info { get; set; }

    public RecordStruct(int x) : this(x,0)
    {
        //Info = "Default Info";
        if(x<10)
         x=x*2;
        Info= $"Info for {x}";
    }
};

// Immutable record struct
// Tostring, descructor, equals, gethashcode auto implemented
//get, intit only properties
public readonly record struct ReadOnlyRecordStruct(int A, int B);

// Positional record struct
// Tostring, descructor, equals, gethashcode auto implemented
// get, set only properties
public record struct PersonStruct(string FirstName, string LastName);