using Xunit;

namespace Battleships.Game.Tests;

public class ShipHitOrMissTests
{
    private Board _board;

    public ShipHitOrMissTests()
    {
        _board = new Board();
    }

    [Theory]
    [InlineData(5, 9, ShellResult.Miss)]
    [InlineData(5, 7, ShellResult.Miss)]
    [InlineData(5, 8, ShellResult.Hit)]
    [InlineData(6, 8, ShellResult.Hit)]
    [InlineData(7, 8, ShellResult.Hit)]
    [InlineData(8, 8, ShellResult.Hit)]
    [InlineData(9, 8, ShellResult.Hit)]
    [InlineData(10, 8, ShellResult.Miss)]
    public void CarrierHorizontalTests(int x, int y, ShellResult expectedResult)
    {
        _board.AddShip(new GridCoordinate(5, 8), Orientation.Horizontal, ShipType.Carrier);

        ShellResult result = _board.ShellFired(new GridCoordinate(x, y));

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(8, 4, ShellResult.Miss)]
    [InlineData(7, 5, ShellResult.Miss)]
    [InlineData(8, 5, ShellResult.Hit)]
    [InlineData(8, 6, ShellResult.Hit)]
    [InlineData(8, 7, ShellResult.Hit)]
    [InlineData(8, 8, ShellResult.Hit)]
    [InlineData(8, 9, ShellResult.Hit)]
    [InlineData(8, 10, ShellResult.Miss)]
    [InlineData(9, 10, ShellResult.Miss)]
    public void CarrierVerticalTests(int x, int y, ShellResult expectedResult)
    {
        _board.AddShip(new GridCoordinate(8, 5), Orientation.Vertical, ShipType.Carrier);

        ShellResult result = _board.ShellFired(new GridCoordinate(x, y));

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 4, ShellResult.Miss)]
    [InlineData(3, 4, ShellResult.Hit)]
    [InlineData(4, 4, ShellResult.Hit)]
    [InlineData(5, 4, ShellResult.Hit)]
    [InlineData(6, 4, ShellResult.Miss)]
    [InlineData(7, 4, ShellResult.Miss)]
    public void CruiserHorizontalTests(int x, int y, ShellResult expectedResult)
    {
        _board.AddShip(new GridCoordinate(3, 4), Orientation.Horizontal, ShipType.Cruiser);

        ShellResult result = _board.ShellFired(new GridCoordinate(x, y));

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 4, ShellResult.Miss)]
    [InlineData(3, 4, ShellResult.Hit)]
    [InlineData(3, 5, ShellResult.Hit)]
    [InlineData(3, 6, ShellResult.Hit)]
    [InlineData(3, 7, ShellResult.Miss)]
    [InlineData(4, 4, ShellResult.Miss)]
    public void CruiserVerticalTests(int x, int y, ShellResult expectedResult)
    {
        _board.AddShip(new GridCoordinate(3, 4), Orientation.Vertical, ShipType.Cruiser);

        ShellResult result = _board.ShellFired(new GridCoordinate(x, y));

        Assert.Equal(expectedResult, result);
    }
}
