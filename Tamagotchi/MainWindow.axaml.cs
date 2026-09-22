using Avalonia.Controls;

namespace Tamagotchi;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContent.Content = new CreationView();
    }
}