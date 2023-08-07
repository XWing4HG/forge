class Pilot
{
    string name;
    string faction;
    int initiative;
    Ability pilotAbility;
    List<Upgrade> upgrades = new List<Upgrade>(); // currently equiped upgrades
    List<Upgrade> avaialbleUpgrades = new List<Upgrade>(); // list of all potential upgrades for this specific pilot (organized by Upgrade.Type)

    public string Name {get {return name;} private set {name = value;}}
    public string Faction {get {return faction;} private set {faction = value;}}
    public int Initiative {get {return initiative;} private set {initiative = value;}}
    public List<Upgrade> Upgrades {get {return upgrades;} private set {upgrades = value;}}
    public List<Upgrade> AvaialbleUpgrades {get {return avaialbleUpgrades;} private set {avaialbleUpgrades = value;}}
    
    public Pilot()
    {
    }

    public void addUpgrade(string type)
    {
        // 
    }
}
