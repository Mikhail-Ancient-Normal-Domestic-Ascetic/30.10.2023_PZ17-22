using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication7.Models;
using AvaloniaApplication8;
using MySqlConnector;

namespace AvaloniaApplication2;

public partial class MainWindow : Window
{
  
    public MainWindow()
    {
        InitializeComponent();
        
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        new AddTypeEquipment().ShowDialog(this);
    }
}