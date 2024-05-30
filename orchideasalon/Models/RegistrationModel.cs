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
    public virtual ServiceModel Service { get; set; }
    
    public int ServiceId { get; set; }
    
    [DisplayName("Ім'я")]
    public string FirstName { get; set; } = "";
    
    [DisplayName("Номер телефону")]
    public string Phone { get; set; } = "";
    
    [DisplayName("День")]
    public virtual WorkingDayModel Day { get; set; }
    
    public int DayId { get; set; }
    
    [DisplayName("Час")]
    public TimeOnly Time { get; set; }
}