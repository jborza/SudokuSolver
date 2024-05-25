internal class Cell
{
    private int x;
    private int y;
    public int Value;

    public Cell(int x, int y, int value)
    {
        this.x = x;
        this.y = y;
        this.Value = value;
        Options = new List<int>();
    }

    public bool HasValue()
    {
        return Value != 0;
    }

    public List<int> Options;

    public override string ToString()
    {
        return Value.ToString();
    }
}