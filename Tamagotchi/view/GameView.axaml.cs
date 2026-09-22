using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Tamagotchi.view;

public partial class GameView : UserControl
{
    public GameView(string nom, Race race)
    {
        InitializeComponent();
        Tamagotchi tamagotchi = new Tamagotchi(nom, race);
    }
}