using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Planer_Dnia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void submitOne(object? sender, RoutedEventArgs e)
    {
        tbOne.Text = textBoxOne.Text;
        var comboBoxValue = (comboBoxOne.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "No selection";
        showTB.Text=comboBoxValue;
    }

    private void submitTwo(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void edit(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}