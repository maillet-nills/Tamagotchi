using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Tamagotchi.view;

public partial class GameView : UserControl
{
    private readonly GameViewModel gameViewModel;
    public GameView(string nom, Race race)
    {
        InitializeComponent();
        gameViewModel = new GameViewModel(nom, race);
        DataContext = gameViewModel;
    }

    private void BTNJouer_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.AddSatisfaction();
    }

    private void BTNNourrir_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.AddSatisfaction();
    }

    private void BTNGronder_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.LowerSatisfaction();
    }

    private void BTNTravailler_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.LowerSatisfaction();
    }

    private void BTNDormir_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.AddSatisfaction();
    }
}