namespace Battleships.Game;

internal class ShipPosition
{
    private List<GridCoordinate> _gridCoordinates;

    public ShipPosition(GridCoordinate bowPosition, GridCoordinate sternPosition)
    {
        _gridCoordinates = new();
        for (int x = bowPosition.X; x <= sternPosition.X; x++)
        {
            for (int y = bowPosition.Y; y <= sternPosition.Y; y++)
            {
                _gridCoordinates.Add(new GridCoordinate(x, y));
            }
        }

        BowPosition = bowPosition;
        SternPosition = sternPosition;
    }

    public bool ContainsCoordinat(GridCoordinate coordinate)
        => _gridCoordinates.Contains(coordinate);

    public GridCoordinate BowPosition { get; } 

    public GridCoordinate SternPosition { get; } 
}
