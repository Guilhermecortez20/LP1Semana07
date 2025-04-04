namespace MyRPG;
class Player
{
    private float health;
    private int XP;
    private int Level;

    public string Name { get; }
    public float MaxHealth
    {
        get => MaxHealth;
        set
        {
            if (value > MaxHealth)
                MaxHealth = value;
        }
    }
    public float TakeDamage => XP> 1 ? (float)TakeDamage / XP  *20;

    public Player(string name)
    {
        Name = name;
        health = 0;
        XP = 0;
        TakeDamage = 0;
    }

    public void TakeDemage (float demage)
    {
        XP++;
        if (demage)
            TakeDamage++;
    }

    public override string ToString() =>
        $"Player: {Name}, Health: {healty}, XP: {XP}, TakeDemage {TakeDamage}";
}
