

internal class SudokuSolver
{
    private int[,] sudoku;
    public Grid grid;

    public SudokuSolver(int[,] sudoku)
    {
        this.sudoku = sudoku;
        this.grid = new Grid(sudoku);
    }

    internal void Print()
    {
        for (int x = 0; x < grid.Width; x++)
        {
            for (int y = 0; y < grid.Height; y++)
            {
                var cell = grid.cells[x * grid.Width + y];
                Console.Write(cell.Value);
            }
            Console.WriteLine();
        }
    }

    internal void Solve()
    {
        //apply known solutions

        //first - fill in the blanks
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[i, j] == 0)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        //TODO magic
                    }
                    return;
                }
            }
        }
    }

    /// <summary>
    /// print out the grid with options
    /// TODO: how to print out the "canceled" options?
    /// it'd be better to use a graphical representation
    /// </summary>
    internal void PrintPretty()
    {
        int previousGridX = -1;
        for (int x = 0; x < grid.Width*3; x++)
        {
            int gridX = x / 3;
            if (gridX != previousGridX)
            {
                Console.WriteLine(new string('-', grid.Width * 3));
                previousGridX = gridX;
            }
            int previousGridY = -1;
            for (int y = 0; y < grid.Height*3; y++)
            {
                int gridY = y / 3;
                if(gridY != previousGridY)
                {
                    Console.Write("|");
                    previousGridY = gridY;
                }
                ///var cell = grid.cells[x * grid.Width + y];
                //Console.Write(cell.Value);
                Console.Write(gridY);
            }
            Console.WriteLine();
        }
    }
}