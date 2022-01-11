namespace Battleships.Game;

internal class Ship
{
    private int _hitCount;

    public Ship(GridCoordinate position, Orientation orientation, ShipType shipType)
        => (Position, Orientation, ShipType) = (position, orientation, shipType);

    public bool Sunk { get; set; }

    public void SetHit()
    {
        _hitCount++;
        //if(_hitCount == Length)
        //{
        //    Sunk = true;
        //}
    }

    public GridCoordinate Position { get; }

    public Orientation Orientation { get; }

    public ShipType ShipType { get; }

    public IEnumerable<GridCoordinate> GetGridCoordinates()
    {
        if (Orientation == Orientation.Horizontal)
        {
            for (int x = Position.X; x < Position.X + ShipType.Size; x++)
            {
                yield return new GridCoordinate(x, Position.Y);
            }
        }
        else
        {
            for (int y = Position.Y; y < Position.Y + ShipType.Size; y++)
            {
                yield return new GridCoordinate(Position.X, y);
            }
        }
    }
}
