public class Recipe
{
    /// <summary>
    /// Slot built by this recipe.
    /// </summary>
    public Slots Slot { get; private set; }

    /// <summary>
    /// Cost of this recipe.
    /// </summary>
    //public Ressource[] Cost { get; private set; }

    private Recipe(Slots slot/*, Truc cost*/)
    {
        Slot = slot;
        //Cost = cost;
    }

    // --- DEFINE GAME RECIPES HERE ---

    public static readonly Recipe Weapon = new Recipe(Slots.Weapon /*, new Truc(5, 2, 1)*/);
    public static readonly Recipe Armor = new Recipe(Slots.Armor /*, new Truc(2, 1, 5)*/);
    public static readonly Recipe Tool = new Recipe(Slots.Tool /*, new Truc(1, 5, 2)*/);
    public static readonly Recipe Boots = new Recipe(Slots.Boots /*, new Truc(3, 3, 3)*/);

    /// <summary>
    /// Possible recipes ingame.
    /// </summary>
    public static readonly Recipe[] List = { Weapon, Armor, Tool, Boots };
}