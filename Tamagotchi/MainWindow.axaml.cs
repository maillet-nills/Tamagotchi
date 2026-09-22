using Avalonia.Controls;
using Tamagotchi.view;

namespace Tamagotchi;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var creation = new view.CreationView();
        creation.IsClicked += IsValid;
        MainContent.Content =  creation;
    }

    private void IsValid(object? sender, (string nom, Race race) infos)
    {
        MainContent.Content = new GameView(infos.nom, infos.race);
    }
}