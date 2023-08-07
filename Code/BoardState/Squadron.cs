class Squadron
{
    string playerId;
    public string PlayerId {get {return playerId;} private set {playerId = value;}}    
    
    List<BoardObject> ships = new List<BoardObject>();

    public Squadron()
    {
    }

    void addShipToSquadron(string playerId, BoardObject ship)
    {
        ships.Add(ship);
    }
}
