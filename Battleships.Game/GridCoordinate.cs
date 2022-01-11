namespace Battleships.Game;

public record struct GridCoordinate
{
    public GridCoordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }

    public int Y { get; }
}
