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
    
    private void edit(object? sender, RoutedEventArgs e)
    {
        var comboBoxValueTwo = (comboBoxTwo.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "No selection";
        showTB.Text=comboBoxValueTwo;
    }
    
    private void submitTwo(object? sender, RoutedEventArgs e)
    {
        tbOne.Text = "";
        textBoxOne.Text = "";
        showTB.Text = "";
        comboBoxOne.SelectedIndex = -1;
        comboBoxTwo.SelectedIndex = -1;
    }
}