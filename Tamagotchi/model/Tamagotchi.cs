namespace Tamagotchi;

public class Tamagotchi
{
    private string nom { get;  set; }
    public string Nom => this.nom;
    private Race race {  get;  set; }
    private NvSatisfaction nvSatisfaction { get; set; }
    private NvTaille nvTaille { get; set; }

    public Tamagotchi(string nom, Race race)
    {
        this.nom = nom;
        this.race = race;
        this.nvSatisfaction = NvSatisfaction.Satisfait;
        this.nvTaille = NvTaille.Petit;
    }

}