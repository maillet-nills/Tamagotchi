using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Tamagotchi.view;

public partial class CreationView : UserControl
{
    public EventHandler<(string nom, Race race)>? IsClicked;
    public CreationView()
    {
        InitializeComponent();
    }

    private void BTNValiderCreation_OnClick(object? sender, RoutedEventArgs e)
    {
        string nom = TBNom.Text;
        string raceStr = (CBRace.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Chat";
        Race race = Enum.Parse<Race>(raceStr);
        
        IsClicked.Invoke(this, (nom, race));
    }
}