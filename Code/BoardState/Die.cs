class Die
{   
    string type; // attack or defense
    public string Type {get {return type;} set {type = value;}}
    
    string[] potentialValues; // dependent on type
    public string[] PotentialValues {get {return potentialValues;} private set {potentialValues = value;}}

    string currentValue;
    public string CurrentValue {get {return currentValue;} set {currentValue = value;}}

    public Die(string type)
    {
        this.type = type;
        generatePotentialValues();
        rollDie();
    }

    void generatePotentialValues()
    {
        switch(type) 
        {
        case "attack":
            potentialValues = new string[8] {"blank", "blank", "focus", "focus", "hit", "hit", "hit", "crit"};
            break;
        case "defense":
            potentialValues = new string[8] {"blank", "blank", "blank", "focus", "focus", "evade", "evade", "evade"};
            break;
        default:
            Console.WriteLine("Not a valid die type.");
            break;
        }
    }

    void rollDie()
    {
        Random roll = new Random();
        currentValue = potentialValues[roll.Next(8)];
    }
}
