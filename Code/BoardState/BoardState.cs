class BoardState
{
    // Set Private Variable Default Values
    public float[,] gameplayGrid; // !!! MAKE PRIVATE !!!
    float[,,] gameplayGridHistory;
    bool autoRuleEnforcementOn = false;
    string phase = "sandbox";

    BoardObject selectedObject;
    BoardObject nextInOrderObject;
    List<Squadron> playerSquadrons = new List<Squadron>(); // tracks which ships belong to which players
    List<BoardObject> boardObjects = new List<BoardObject>(); // tracks current objects on board
    List<BoardObject> availableBoardObjects = new List<BoardObject>(); // tracks available board objects

    // Getters/Setters
    public bool AutoRuleEnforcementOn
    {
        get {return autoRuleEnforcementOn; }
        set {if (value == true || value == false) {autoRuleEnforcementOn = value;} else {Console.WriteLine("Can't Set that Value for autoRuleEnforcement");}}
    }
    public string Phase {get {return phase;} private set {phase = value;}}
    public BoardObject SelectedObject {get {return selectedObject;} set {selectedObject = value;}}
    public BoardObject NextInOrderObject {get {return nextInOrderObject;} private set {nextInOrderObject = value;}}
    public List<Squadron> PlayerSquadrons {get {return playerSquadrons;} private set {playerSquadrons = value;}}
    public List<BoardObject> BoardObjects {get {return boardObjects;} private set {boardObjects = value;}}
    public float[,,] GameplayGridHistory {get {return gameplayGridHistory;} private set {gameplayGridHistory = value;}}

    // Constructor
    public BoardState(int[] size)
    {
        this.generateBoard(size);
    }

    // Board Methods (can be used to reset board by setting default value to 0)
    void generateBoard(int[] size, int defaultValue = 0)
    {
        int numberOfRows = size[0];
        int numberOfColumns = size[1];
        gameplayGrid = new float[numberOfRows,numberOfColumns];

        for (int r = 0; r < numberOfRows; r++) {
            for (int c = 0; c < numberOfColumns; c ++) {
                gameplayGrid[r,c] = defaultValue;
            }
        }
    }

    void findNextInTurnOrderObject(BoardObject selectedObject) {
    }

    void updateGameplayGridHistory() {
    }
}
