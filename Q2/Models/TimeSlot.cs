using System;
using System.Collections.Generic;

namespace Q2.Models;

public partial class TimeSlot
{
    public int Id { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public String toString
    {
        get { return StartTime + "-" + EndTime; }
    }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
