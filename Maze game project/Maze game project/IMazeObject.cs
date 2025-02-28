 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    internal interface IMazeObject
    {
       char Icon { get;}
       bool IsSolid { get;  } //Movement block

    }
}
