class Ship
{
    int hull = 0;
    int shields = 0;
    int attackValue = 0;
    int defenseValue = 0;
    Ability shipAbility;
    Pilot pilot;
    List<Pilot> availablePilots = new List<Pilot>();

    public int Hull {get {return hull;} set {hull = value;}}
    public int Shields {get {return shields;} set {shields = value;}}
    public int AttackValue {get {return attackValue;} set {attackValue = value;}}
    public int DefenseValue {get {return defenseValue;} set {defenseValue = value;}}
    
    public Ship()
    {
        selectPilot("poe");
    }

    public void selectPilot(string name)
    {
        // then sets stats
    }


}
