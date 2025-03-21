using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace YogaMasterskyaMVC.Models
{
    [Table("schedule")]
    public class ScheduleEntry
    {
        [Column("id")] public int Id { get; set; }
        [Column("time")] public TimeOnly Time { get; set; }
        [Column("teacher_id")] public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        [Column("direction")] public string Direction { get; set; }
        [Column("day")] public string Day { get; set; }
        public DayOfWeek GetDayEnum()
        {
            return Day switch
            {
                "Пн" => DayOfWeek.Monday,
                "Вт" => DayOfWeek.Tuesday,
                "Ср" => DayOfWeek.Wednesday,
                "Чт" => DayOfWeek.Thursday,
                "Пт" => DayOfWeek.Friday,
                "Сб" => DayOfWeek.Saturday,
                "Вс" => (DayOfWeek)7
            };
        }
        
    }
}
