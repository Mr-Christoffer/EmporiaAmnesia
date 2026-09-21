class Player
{
    public int Row { get; set; }
    public int Col { get; set; }

    public Backpack backpack {get;} = new();

    public Player(int startRow, int startCol)
    {
        int row = startRow;
        int col = startCol;
    }

    
}