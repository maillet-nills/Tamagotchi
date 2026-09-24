using System;

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

    public void AddSatisfaction()
    {
        switch (this.nvSatisfaction)
        {
            case NvSatisfaction.PasSatisfait:
                this.nvSatisfaction = NvSatisfaction.Satisfait;
                break;
            
            case NvSatisfaction.Satisfait:
                this.nvSatisfaction = NvSatisfaction.TresSatisfait;
                break;
        }
        
        Console.WriteLine(this.nvSatisfaction);
    }

    public void LowerSatisfaction()
    {
        switch (this.nvSatisfaction)
        {
            case NvSatisfaction.TresSatisfait:
                this.nvSatisfaction = NvSatisfaction.Satisfait;
                break;
            
            case NvSatisfaction.Satisfait:
                this.nvSatisfaction = NvSatisfaction.PasSatisfait;
                break;
        }
        
        Console.WriteLine(this.nvSatisfaction);
    }

}