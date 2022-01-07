namespace Battleships.Game;

internal class Ship
{
    public Ship(ShipPosition position)
        => Position = position;

    public int Length { get; set; }

    public int HitCount { get; set; }

    public ShipPosition Position { get; } 
}
