using System.ComponentModel;

namespace orchideasalon.Models;

public class ServiceModel
{
    [DisplayName("ID послуги")]
    public int Id { get; set; }
    
    [DisplayName("Назва")]
    public string Name { get; set; } = "";
    
    [DisplayName("Опис")]
    public string Description { get; set; } = "";
    
    [DisplayName("Ціна від")]
    public decimal Price { get; set; }
}