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

        if (comboBoxOne.SelectedItem is ComboBoxItem)
        {
            comboBoxTwo.SelectedIndex = comboBoxOne.SelectedIndex;
        }
        
        textBoxOne.Text = "";
    }
    
    
    private void submitTwo(object? sender, RoutedEventArgs e)
    {
        tbOne.Text = "";
        textBoxOne.Text = "";
        showTB.Text = "";
        comboBoxOne.SelectedIndex = -1;
        comboBoxTwo.SelectedIndex = -1;
    }

    private void comboBoxTwo_Zmiana(object? sender, SelectionChangedEventArgs e)
    {
        UpdateTaskList();
    }

    private void UpdateTaskList()
    {
        string taskName = tbOne.Text;
        string category = (comboBoxTwo.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "Brak kategorii";
        string status = checkBoxOne.IsChecked == true ? "Ukończone" : "Nieukończone";
        
        taskList.Text += $"{taskName} - {category} - {status}\n";
            
    }

}