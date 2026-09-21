class Map
{
    private Location?[][] locations =
    {
        new Location?[5] {null, null, new Escalator1(),  new Roof(), null},
        new Location?[5] {new Foyer(), new Escalator2(), new CorridorA(), null, null},
        new Location?[5] {new Toiletstall(), null,new OutsideDryCleaner(), new CorridorB(), null},
        new Location?[5] {null, null, new DryCleaner(), new SecurityOffice(), new Taxistation()}
    };

    public Location GetLocation(int row, int col)
    {
        return locations[row][col]!;
    }

    public bool PositionExists(int row, int col)
    {
        if (row < 0 || row >= locations.Length) // Is row out of bounds?
        {
            return false;
        }
        if (col < 0 || col >= locations.Length) // Is column out of bounds?
        {
            return false;
        }
        if (locations[row][col] == null) // Is position on a null "cell"?
        {
            return false;
        }
        return true;
    }

}