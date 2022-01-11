namespace Battleships.Game;

public record ShipType
{
    public readonly static ShipType Carrier = new(5, nameof(Carrier));

    public readonly static ShipType Battleship = new(4, nameof(Battleship));

    public readonly static ShipType Cruiser = new(3, nameof(Cruiser));

    public readonly static ShipType Submarine = new(3, nameof(Submarine));

    public readonly static ShipType Destroyer = new(2, nameof(Destroyer));

    private ShipType(int size, string type)
        => (Size, Type) = (size, type);

    public int Size { get; }

    public string Type { get; }
}
