class Upgrade
{
    string type;
    string title;
    Ability upgradeAbility;
    int cost;

    public string Type {get {return type;} private set {type = value;}}
    public string Title {get {return title;} private set {title = value;}}
    public Ability UpgradeAbility {get {return upgradeAbility;} private set {upgradeAbility = value;}}
    public int Cost {get {return cost;} private set {cost = value;}}

    public Upgrade()
    {
    }
}
