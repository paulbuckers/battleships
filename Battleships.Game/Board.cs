namespace Battleships.Game;

public class Board
{
    private readonly int _boardSize = 10;

    private Dictionary<ShipType, Ship> _ships = new();

    private Dictionary<GridCoordinate, GridCell> _gridCells = new();

    public bool AddShip(GridCoordinate position, Orientation orientation, ShipType shipType)
    {
        Ship ship = new Ship(position, orientation, shipType);

        GridCoordinate[] coordinates = ship.GetGridCoordinates().ToArray();

        if (coordinates.Any(c => _gridCells.ContainsKey(c) || c.X >= _boardSize || c.Y >= _boardSize)) return false; 

        foreach (GridCoordinate coordinate in coordinates)
        {
            _gridCells.Add(coordinate, new OccupiedGridCell(ship));
        }

        _ships.Add(shipType, ship);

        return true;
    }

    public ShellResult ShellFired(GridCoordinate gridCoordinate)
    {
        if(! _gridCells.TryGetValue(gridCoordinate, out GridCell? existingCell))
        {
            _gridCells.Add(gridCoordinate, new EmptyGridCell());
            return ShellResult.Miss;
        }

        if(existingCell is OccupiedGridCell occupiedCell)
        {
            occupiedCell.SetHit();
            return ShellResult.Hit;
        }

        throw new ArgumentException($"Cell {gridCoordinate} has already been shelled and missed");
    }
}
