class Ability
{
    string type; 
    string timing; 
    List<string> availableTypes = new List<string>(); // place item (by id), roll dice, reroll dice, dice add, dice subtract, die change, asteroid ignore, bomb damage ignore, boost, barrel roll.
    List<string> availableTimings = new List<string>(); // when the ability activates: phase/ship shooting/ship defending/ship beginning activation/ship ending activation.

    public Ability()
    {
    }
}
