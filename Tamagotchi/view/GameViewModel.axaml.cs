using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Tamagotchi.view;

public partial class GameViewModel : ObservableObject
{
    [ObservableProperty]
    private string nom;
    
    public Tamagotchi TamagotchiModel { get; }
    
    public GameViewModel(string nom, Race race)
    {
        TamagotchiModel = new Tamagotchi(nom, race);
        this.nom = nom;
    }
}