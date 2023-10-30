using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaApplication7.Models;
using MySqlConnector;

namespace AvaloniaApplication8;

public partial class AddOrderEquipment : Window
{
    private List<OrderEquipment> OrderEquipmentt { get; set; }
    private MySqlConnectionStringBuilder _connectionSb;
    public AddOrderEquipment()
    {
      
    
        InitializeComponent();
        OrderEquipmentt = new List<OrderEquipment>();
        _connectionSb = new MySqlConnectionStringBuilder
        {
            Server = "10.10.1.24",
            Database = "pro2",
            UserID = "user_01",
            Password = "user01pro"

        };
        UpdateDataGrid();
    }

    private void UpdateDataGrid()
    {
        using (var connection = new MySqlConnection(_connectionSb.ConnectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT *FROM OrderEquipment ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderEquipmentt.Add(new OrderEquipment()
                        {
                            Id= reader.GetInt32("Id"),
                            Date = reader.GetDateTime("Date"),
                            Client = reader.GetInt32("Name"),
                            Worker = reader.GetInt32("Name"),
                            TypeEquipment= reader.GetInt32("Name"),
                            Typefault = reader.GetInt32("Name"),
                            SerialNumber = reader.GetInt32("Name"),
                            DescriptionProblem = reader.GetString("Name"),
                            
                        });
                    }
                    
                }
            }
            connection.Close();
        }

        GroupsDataGrid2.ItemsSource = OrderEquipmentt;
    }
}