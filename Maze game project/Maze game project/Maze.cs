using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    public class Maze
    {
        private Player _player;
        private int _Width;
        private int _Hight;
        private IMazeObject[,] _MazeObjectArray;

        public Maze(int width , int hight )
        {
            _Width = width;
            _Hight = hight;
            _MazeObjectArray = new IMazeObject[width, hight];
            _player = new Player()
            {
                X = 1,
                Y = 1,
            };

            
        }
        
        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < _Hight; y++)
            {
                for (int x = 0; x < _Width; x++)
                {
                    if (x==39 &&y==15)
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].Icon);

                    }
                    if (x==0 || y==0 || x==_Width-1 || y == _Hight-1)
                    {
                        _MazeObjectArray[x, y] = new Wall();

                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else if(x==_player.X && y==_player.Y)
                    {
                        Console.Write(_player.Icon);
                    }
                    else if (x%3==0 && y%3==0)
                    {
                        _MazeObjectArray[x, y] = new Wall();

                        Console.Write(_MazeObjectArray[x, y].Icon);

                    }
                    else
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x,y].Icon);
                    }
                   

                }
                Console.WriteLine();

            }

        }
        public void MovePlayer()
        {
            ConsoleKeyInfo userInput =  Console.ReadKey();

            ConsoleKey Key = userInput.Key;

            switch (Key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;

                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                     break;

                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                     break;

                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                     break;
                    
            }



        }

        private void UpdatePlayer (int dx , int dy)
        {
            int newx = _player.X + dx;
            int newy = _player.Y + dy;
            if (newx <_Width && newx>=0 && newy <_Hight && newy >= 0 && _MazeObjectArray[newx,newy].IsSolid==false )
            {
                _player.X = newx;
                _player.Y = newy;
                DrawMaze();
            }
            
        }

    }
}
