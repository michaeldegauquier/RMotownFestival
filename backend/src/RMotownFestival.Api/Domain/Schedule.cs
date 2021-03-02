using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMotownFestival.Api.Domain
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public List<ScheduleItem> Items { get; set; }

        public Schedule()
        {
            Items = new List<ScheduleItem>();
        }
    }
}
