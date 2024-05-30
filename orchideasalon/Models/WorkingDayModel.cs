using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace orchideasalon.Models;

[Index(nameof(Date), IsUnique = true)]
public class WorkingDayModel
{
    [DisplayName("ID дня")]
    public int Id { get; set; }
    
    [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
    [DisplayName("Дата")]
    public DateOnly Date { get; set; }
    
    [DisplayName("Час початку")]
    public TimeOnly BeginTime { get; set; }
    
    [DisplayName("Час закінчення")]
    public TimeOnly EndTime { get; set; }
}