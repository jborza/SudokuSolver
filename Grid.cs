

internal class Grid
{
    public List<Cell> cells;
    public int Height => 9;
    public int Width => 9;

    public Grid(int[,] sudoku)
    {
        cells = new List<Cell>();
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                cells.Add(new Cell(x, y, sudoku[x, y]));
            }
        }
    }

    public void AutoFill()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                var cell = GetCell(x, y);
                cell.Options = GetOptions(x, y, cell);
            }
        }
    }

    private List<int> GetOptions(int x, int y, Cell cell)
    {
        //generate options for row, column, region
        int row = y;
        int column = x;
        int region = (x / 3) * 3 + y / 3;
        //check cells in the row to see what value is missing
        List<int> rowOptions = GetRowOptions(row, cell);
        List<int> columnOptions = GetColumnOptions(column, cell);
        List<int> regionOptions = GetRegionOptions(region, cell);
        //return the intersection of the three lists
        return rowOptions.Intersect(columnOptions).Intersect(regionOptions).ToList();
    }

    private List<int> GetRegionOptions(int region, Cell cell)
    {
        //get the region from the board
        List<int> regionValues = new List<int>();
        //regions are 3x3, numbered as 
        // 0 1 2
        // 3 4 5
        // 6 7 8
        int regionX = region / 3;
        int regionY = region % 3;
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                var value = GetRegionValue(regionX * 3 + x, regionY * 3 + y);
                if (value != 0)
                {
                    regionValues.Add(value);
                }
            }
        }
        return GetRegionOptions(regionValues, cell);
    }

    private List<int> GetRegionOptions(List<int> regionValues, Cell cell)
    {
        //return numbers from 1 to 9 that are not in the region
        List<int> options = new List<int>();
        for (int i = 1; i <= 9; i++)
        {
            if (!regionValues.Contains(i))
            {
                options.Add(i);
            }
        }
        return options;
    }

    private Cell GetCell(int x, int y)
    {
        return cells[x + y * Width];
    }

    private int GetRegionValue(int x, int y)
    {
        return cells[x + y * Width].Value;
    }

    private List<int> GetColumnOptions(int column, Cell cell)
    {
        //get the row from the board
        List<int> columnValues = new List<int>();
        for (int x = 0; x < Width; x++)
        {
            var value = GetColumnValue(x, column);
            if (value != 0)
            {
                columnValues.Add(value);
            }
        }
        //get the options for current cell
        return GetColumnOptions(columnValues, cell);
    }

    private List<int> GetColumnOptions(List<int> columnValues, Cell cell)
    {
        //return numbers from 1 to 9 that are not in the column
        List<int> options = new List<int>();
        for (int i = 1; i <= 9; i++)
        {
            if (!columnValues.Contains(i))
            {
                options.Add(i);
            }
        }
        return options;
    }

    private int GetColumnValue(int y, int column)
    {
        return cells[column + y * Width].Value;
    }

    private List<int> GetRowOptions(int row, Cell cell)
    {
        //get the row from the board
        List<int> rowValues = new List<int>();
        for (int x = 0; x < Width; x++)
        {
            var value = GetRowValue(x, row);
            if (value != 0)
            {
                rowValues.Add(value);
            }
        }
        //get the options for current cell
        return GetRowOptions(rowValues, cell);
    }

    private List<int> GetRowOptions(List<int> rowValues, Cell cell)
    {
        //return numbers from 1 to 9 that are not in the row
        List<int> options = new List<int>();
        for (int i = 1; i <= 9; i++)
        {
            if (!rowValues.Contains(i))
            {
                options.Add(i);
            }
        }
        return options;
    }

    private int GetRowValue(int x, int row)
    {
        return cells[x + row * Width].Value;
    }

    internal Tuple<int, int> GetCoords(int n)
    {
        n -= 1;
        return Tuple.Create(n % 3 * 30, n / 3 * 30);
    }

    internal Image Draw()
    {
        Bitmap bitmap = new Bitmap(900, 900);
        using (Graphics g = Graphics.FromImage(bitmap))
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var cell = cells[x + y * Height];
                    //is it a cell with value or not?
                    if (cell.HasValue())
                        g.DrawString(cell.Value.ToString(),
                            new Font("Arial", 32),
                            Brushes.Black,
                            x * 100,
                            y * 100);
                    else
                    {
                        //draw options
                        for (int i = 0; i < cell.Options.Count; i++)
                        {
                            //use fixed position per numbers
                            var coords = GetCoords(cell.Options[i]);
                            g.DrawString(cell.Options[i].ToString(),
                                new Font("Arial", 12),
                                    Brushes.Gray,
                                    x * 100 + coords.Item1,
                                    y * 100 + coords.Item2);
                        }
                    }
                    g.DrawLine(Pens.Gray, x * 100, 0, x * 100, 900);
                }
                g.DrawLine(Pens.Gray, 0, y * 100, 900, y * 100);
            }
        }
        return bitmap;
    }
}