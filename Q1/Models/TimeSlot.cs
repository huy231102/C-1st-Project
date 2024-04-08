using System;
using System.Collections.Generic;

namespace Q1.Models;

public partial class TimeSlot
{
    public int Id { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string TimeString{
        get { return this.StartTime + " - " + this.EndTime; }
    }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
