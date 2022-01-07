using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Game;

internal class Shell
{
    public Shell(GridCoordinate gridCoordinate, ShellResult shellResult)
    {
        GridCoordinate = gridCoordinate;
        ShellResult = shellResult;
    }

    public GridCoordinate GridCoordinate { get; }
    
    public ShellResult ShellResult { get; }
}
