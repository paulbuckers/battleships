namespace Battleships.Game;

internal class Board
{
    private Ship[] _ships;

    private Dictionary<GridCoordinate, Shell> _shells = new();

    public Board()
    {
        _ships = new Ship[]
        {
            new Ship(new ShipPosition(new GridCoordinate(0, 0), new GridCoordinate(0, 3))),
            new Ship(new ShipPosition(new GridCoordinate(0, 0), new GridCoordinate(1, 3))),
            new Ship(new ShipPosition(new GridCoordinate(0, 0), new GridCoordinate(2, 3))),
            new Ship(new ShipPosition(new GridCoordinate(0, 0), new GridCoordinate(3, 3)))
        };
    }
}
