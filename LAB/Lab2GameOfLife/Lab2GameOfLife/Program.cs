using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    class Program
    {
        static readonly int MAX_GENERATIONS = 10;
        static void Main(string[] args)
        {
            Game game = new OscilatorGame(OscilatorGame.GameType.Pulsar, MAX_GENERATIONS);
            while (game.CurrentGeneration <= game.MaxGenerations)
            {
                game.Show();
                game.Evolve();
                Thread.Sleep(1000);
            }
            Console.WriteLine("Evaluation ended!\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class Cell
    {
        public bool IsAlive { get; set; }
        public bool ShouldLive { get; set; }

        public Cell()
        {
            IsAlive = false;
            ShouldLive = false;
        }

        public override string ToString()
        {
            if (IsAlive)
                return " X ";
            return " _ ";
        }
    }

    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Cell[][] Cells { get; set; }

        public Grid(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;

            Cells = new Cell[rows][];
            for(int i = 0; i < rows; i++)
            {
                Cells[i] = new Cell[Columns];
                for(int j = 0; j < columns; j++)
                {
                    Cell newCell = new Cell();
                    Cells[i][j] = newCell;
                }
            }
        }

        public void ToggleCell(int x, int y, bool isAlive)
        {
            Cells[x][y].IsAlive = isAlive; // OVDE MOZDA IMA GRESKA
            //if (Cells[x][y].IsAlive)
            //    Cells[x][y].IsAlive = false;
            //else
            //    Cells[x][y].IsAlive = true;
        }

        public void Evolve()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int aliveNeighbors = 0;
                    if (i - 1 >= 0 && j - 1 >= 0 && Cells[i - 1][j - 1].IsAlive)
                        aliveNeighbors++;
                    if (i - 1 >= 0 && j < Columns && Cells[i - 1][j].IsAlive)
                        aliveNeighbors++;
                    if (i - 1 >= 0 && j + 1 < Columns && Cells[i - 1][j + 1].IsAlive)
                        aliveNeighbors++;

                    if (i >= 0 && j - 1 >= 0 && Cells[i][j - 1].IsAlive)
                        aliveNeighbors++;
                    if (i >= 0 && j + 1 < Columns && Cells[i][j + 1].IsAlive)
                        aliveNeighbors++;

                    if (i + 1 < Rows && j - 1 >= 0 && Cells[i + 1][j - 1].IsAlive)
                        aliveNeighbors++;
                    if (i + 1 < Rows && j < Columns && Cells[i + 1][j].IsAlive)
                        aliveNeighbors++;
                    if (i + 1 < Rows && j + 1 < Columns && Cells[i + 1][j + 1].IsAlive)
                        aliveNeighbors++;

                    if (Cells[i][j].IsAlive && (aliveNeighbors < 2 || aliveNeighbors > 3))
                        Cells[i][j].ShouldLive = false;
                    else if (Cells[i][j].IsAlive && (aliveNeighbors == 2 || aliveNeighbors == 3))
                        Cells[i][j].ShouldLive = true;
                    else if (!Cells[i][j].IsAlive && aliveNeighbors == 3)
                        Cells[i][j].ShouldLive = true;
                    else
                        Cells[i][j].ShouldLive = false;

                }
            }

            for (int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    if (Cells[i][j].ShouldLive)
                        Cells[i][j].IsAlive = true;
                    else
                        Cells[i][j].IsAlive = false;    
                }
            }
            
        }

        public override string ToString()
        {
            string output = "";
            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    output += Cells[i][j];
                    if (j == Columns - 1)
                        output += "\n";
                }
            }
            return output;
        }

    }

    abstract class Game
    {
        protected Grid grid;
        public int CurrentGeneration { get; set; }
        public int MaxGenerations { get; set; }

        public Game(int maxGenerations)
        {
            this.MaxGenerations = maxGenerations;
            this.CurrentGeneration = 0;
        }

        public void Evolve()
        {
            
            grid.Evolve();
            CurrentGeneration++;
            
            
        }

        virtual public void Show()
        {
            Console.Clear();
            Console.WriteLine("Current Generation: {0}", CurrentGeneration);
            Console.WriteLine(grid);
        }
    }

    class StillLifeGame : Game
    {
        public enum GameType
        {
            Block,
            Beehive,
            Loaf,
            Boat
        }
        public GameType Type { get; set; }
        public StillLifeGame(GameType type, int maxGenerations) : base(maxGenerations)
        {
            this.Type = type;
            if(Type == GameType.Block)
            {
                grid = new Grid(4, 4);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
            }

            if (Type == GameType.Beehive)
            {
                grid = new Grid(5, 6);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 2, true);
                grid.ToggleCell(3, 3, true);
            }

        }

        public override void Show()
        {
            Console.Title = String.Format("Still game of life: {0}", Type);
            base.Show();
        }
    }

     class OscilatorGame : Game
    {
        public enum GameType
        {
            Blinker,
            Toad,
            Beacon,
            Pulsar
        }

        public GameType Type { get; set; }
        public OscilatorGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            this.Type = gameType;

            if (gameType == GameType.Blinker)
            {
                grid = new Grid(5, 5);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(2, 3, true);
            }

            if (gameType == GameType.Toad)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(3, 1, true);
                grid.ToggleCell(4, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 4, true);
            }
            if (gameType == GameType.Beacon)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(3, 3, true);
                grid.ToggleCell(3, 4, true);
                grid.ToggleCell(4, 3, true);
                grid.ToggleCell(4, 4, true);
            }
            if (gameType == GameType.Pulsar)
            {
                grid = new Grid(17, 17);
                for (int i = 0; i < 17; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        if (i == 2 || i == 7 || i == 9 || i == 14)
                        {
                            if (j == 4 || j == 5 || j == 6 || j == 10 || j == 11 || j == 12)
                            {
                                grid.ToggleCell(i, j, true);
                            }
                        }
                        if ((i >= 4 && i <= 6) || (i >= 10 && i <= 12))
                        {
                            if (j == 2 || j == 7 || j == 9 || j == 14)
                            {
                                grid.ToggleCell(i, j, true);
                            }

                        }
                    }
                }
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Oscilator Game of Life: {0}", Type);
            base.Show();
        }

    }
}
