using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Planer_Dnia;

public partial class MainWindow : Window
{
    private List<string> tasks = new List<string>();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void submitOne(object? sender, RoutedEventArgs e)
    {
        string taskName = textBoxOne.Text;

        if (!string.IsNullOrWhiteSpace(taskName))
        {
            tbOne.Text = taskName;
            string category = (comboBoxOne.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "Brak kategorii";
            string status = checkBoxOne.IsChecked == true ? "Ukończone" : "Nieukończone";
            
            string taskEntry = $"{taskName} - {category} - {status}";
            tasks.Add(taskEntry);
            
            UpdateTaskList();
        }
        textBoxOne.Text = "";
    }


    private void submitTwo(object? sender, RoutedEventArgs e)
    {
        if (tasks.Count > 0)
        {
            tasks.RemoveAt(tasks.Count - 1);
            UpdateTaskList();
        }
    }

    private void comboBoxTwo_Zmiana(object? sender, SelectionChangedEventArgs e)
    {
        UpdateTaskList();
    }

    private void UpdateTaskList()
    {
        taskList.Text = string.Join("\n", tasks);
            
    }

    private void cb_checked(object? sender, RoutedEventArgs e)
    {
        if (tasks.Count > 0)
        {
            tasks[tasks.Count - 1] = tasks[tasks.Count - 1].Replace("Nieukończone", "Ukończone");
            UpdateTaskList();
        }
    }
}