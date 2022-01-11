namespace Battleships.Game;

internal abstract class GridCell
{
    public GridCoordinate Coordinates { get; set; }
}

internal class EmptyGridCell : GridCell
{

}

internal class OccupiedGridCell : GridCell
{
    public OccupiedGridCell(Ship ship)
        => Ship = ship;

    public bool HasBeenHit { get; set; }

    public Ship Ship { get; set; } = null!;

    internal void SetHit()
    {
        if (HasBeenHit) throw new ArgumentException($"Cell {Coordinates} has already been hit!");

        HasBeenHit = true;
        Ship.SetHit();
    }
}
