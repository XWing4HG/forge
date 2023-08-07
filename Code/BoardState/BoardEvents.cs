class BoardEvents
{
    List<Die> diceResults = new List<Die>();
    public List<Die> DiceResults {get {return diceResults;} private set {diceResults = value;}}

    public BoardEvents()
    {
    }

    public void placeBoardObject(BoardObject newBoardObject, float[] placementOnGrid)
    {
        // place newBoardObject on the board in the position placementOnGrid[0] = x and placementOnGrid[1] = y
        // BoardState.BoardObjects.Add(newBoardObject)
        // BoardState.SelectedObject = newBoardObject
    }

    public void updateBoardObject(string id, string action) // actions could be: delete, add upgrade, remove upgrade, etc.
    {
        // check for an object with an Object.Id = id
        // if not found, exit and display error message
        // if found, check if action is applicable to the object
        
        // if not applicable, exit and display error message
        // if applicable, perform action and exit
    }

    List<BoardObject> checkAvailableTargets(float[,] gameplayGrid, BoardObject attackingShip)
    {
        List<BoardObject> availableTargets = new List<BoardObject>();
        return availableTargets;
    }

    public void rollDice(string type, int numberOfDice, List<Ability> modifiers)
    {
        Die newDie;
        diceResults.Clear();
        for (int i = 0; i < numberOfDice; i++) {newDie = new Die(type); diceResults.Add(newDie);}
        // apply attacking modifiers
        // apply defending modifiers
    }

    // need to access applicable modifiers (list of attacking modifiers and defending modifiers)
    public void modifyDice()
    {
    }

    void resolveMovement() {
    }

    void resolveAsteroidHit() {
    }

    void resolveBump() {
    }

    void resolveAction(){
    }
}
