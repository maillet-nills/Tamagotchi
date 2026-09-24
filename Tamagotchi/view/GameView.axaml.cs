using System;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using LibVLCSharp.Shared;

namespace Tamagotchi.view;

public partial class GameView : UserControl
{
    private readonly GameViewModel gameViewModel;
    private readonly LibVLC libVlc;
    private MediaPlayer? lecteur;
    public GameView(string nom, Race race)
    {
        Core.Initialize();
        libVlc = new LibVLC();
        
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
        gameViewModel.TamagotchiModel.AddTaille();
    }

    private void BTNGronder_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.LowerSatisfaction();
    }

    private void BTNTravailler_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.LowerSatisfaction();
        gameViewModel.TamagotchiModel.LowerTaille();
    }

    private void BTNDormir_OnClick(object? sender, RoutedEventArgs e)
    {
        gameViewModel.TamagotchiModel.AddSatisfaction();
    }

    private void BTNTuer_OnClick(object? sender, RoutedEventArgs e)
    {
        JouerSon("shot.mp3");
        Tamago.Classes.Remove("balance");
        Tamago.Classes.Add("tombe");
    }
    
    private void JouerSon(string fichier)
    {
        var uri = new Uri($"avares://Tamagotchi/assets/{fichier}");
        var flux = AssetLoader.Open(uri);
        var media = new Media(libVlc, new StreamMediaInput(flux));

        lecteur?.Dispose();
        lecteur = new MediaPlayer(media);
        lecteur.Play();
    }
}