using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace orchideasalon.Models;

public class RegistrationModel
{
    [DisplayName("ID запису")]
    public Guid Id { get; set; }
    
    [NotMapped]
    [DisplayName("ID запису")]
    public string ShortId => Id.ToString()[..8];

    [DisplayName("Послуга")]
    public ServiceModel? Service { get; set; }
    
    public int? ServiceId { get; set; }
    
    [DisplayName("Ім'я")]
    public string FirstName { get; set; } = "";
    
    [DisplayName("Номер телефону")]
    public string Phone { get; set; } = "";

    [DisplayName("Дaта")] 
    public DateTime? Date { get; set; }
    
    [DisplayName("Нотатки")]
    public string Notes { get; set; } = "";

    [DisplayName("Підтверджено")] 
    public bool Approved { get; set; } = false;
}