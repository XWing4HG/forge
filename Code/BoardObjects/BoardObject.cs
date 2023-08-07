class BoardObject
{
    string id;
    float[] placementOnGrid;

    public string Id {get {return id;} set {id = value;}}
    public float[] PlacementOnGrid {get {return placementOnGrid;} set {placementOnGrid = value;}}

    public BoardObject()
    {
    }
}
