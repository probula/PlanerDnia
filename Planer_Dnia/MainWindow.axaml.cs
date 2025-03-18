using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Planer_Dnia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public class Task
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Category} - {Status}";
        }
    };
    
    ObservableCollection<Task> tasks = new ObservableCollection<Task>();

    private void submitOne(object? sender, RoutedEventArgs e)
    {
        var task = new Task()
        {
            Name = textBoxOne.Text,
            Category = (comboBoxOne.SelectedItem as ComboBoxItem)?.Content?.ToString(),
            Status = checkBoxOne.IsChecked == true ? "Ukończone" : "Nieukończone"
        };

        tasks.Add(task);
        tbOne.Text = task.Name;
        UpdateTaskList();
        textBoxOne.Text = "";
        comboBoxOne.SelectedIndex = -1;
        checkBoxOne.IsChecked = false;
    }


    private void submitTwo(object? sender, RoutedEventArgs e)
    {
        tasks.Clear();
        UpdateTaskList();
        tbOne.Text = "";
    }

    private void UpdateTaskList()
    {
        taskList.ItemsSource = null;
        taskList.ItemsSource = tasks;
    }
    
    private void comboBoxTwo_Zmiana(object? sender, SelectionChangedEventArgs e)
    {
        if (taskList.SelectedItem is Task selectedTask)
        {
            selectedTask.Category = (comboBoxTwo.SelectedItem as ComboBoxItem)?.Content?.ToString();
            UpdateTaskList();
        }
    }

    private void cb_checked(object? sender, RoutedEventArgs e)
    {
        if (taskList.SelectedItem is Task selectedTask)
        {
            selectedTask.Status = checkBoxOne.IsChecked == true ? "Ukończone" : "Nieukończone";
            UpdateTaskList();
        }
    }
}