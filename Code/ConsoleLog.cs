class Display
{
    static void displayGameplayGrid(float[,] gameplayGrid)
    {
        int numberOfRows = gameplayGrid.GetLength(0);
        int numberOfColumns = gameplayGrid.GetLength(1);

        for (int r = 0; r < numberOfRows; r++) {
            for (int c = 0; c < numberOfColumns; c ++) {
                Console.Write($"{gameplayGrid[r,c]} ");
            }
            Console.Write("\n");
        }
    }

    static void displayDiceResults(List<Die> diceResults)
    {
        foreach (Die currentDie in diceResults) {Console.Write($"{currentDie.CurrentValue} ");}
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // initialize board display
        int[] gameplayGridSize = new int[2] {50, 50};
        BoardState boardState = new BoardState(gameplayGridSize);

        // test board state
        Console.WriteLine($"phase: {boardState.Phase}");
        
        boardState.AutoRuleEnforcementOn = true;
        Console.WriteLine($"rule enforcement: {boardState.AutoRuleEnforcementOn}");
        
        // boardState.SelectedObject.;
        // Console.WriteLine($"selected object id: {boardState.SelectedObjectId}\n");

        // displayGameplayGrid(boardState.gameplayGrid);

        // test dice mechanics
        BoardEvents trigger = new BoardEvents();
        List<Ability> modifiers = new List<Ability>();
        Ability test = new Ability();
        modifiers.Add(test);
        trigger.rollDice("attack", 3, modifiers);
        displayDiceResults(trigger.DiceResults);
        trigger.rollDice("defense", 3, modifiers);
        displayDiceResults(trigger.DiceResults);
    }
}
