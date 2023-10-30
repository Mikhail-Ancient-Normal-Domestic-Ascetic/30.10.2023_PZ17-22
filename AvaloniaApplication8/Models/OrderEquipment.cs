using System;
using System.Runtime.InteropServices.JavaScript;

namespace AvaloniaApplication7.Models;

public class OrderEquipment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Client { get; set; }
    public int Worker { get; set; }

    public int TypeEquipment { get; set; }
    
    public int Typefault { get; set; }
    public int SerialNumber {get; set; }
    public string  DescriptionProblem {get; set; }
}