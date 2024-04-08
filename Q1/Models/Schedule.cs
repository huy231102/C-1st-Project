using System;
using System.Collections.Generic;

namespace Q1.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int RoomId { get; set; }

    public int? TimeSlotId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Note { get; set; }

    public virtual Movie Movie { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;

    public virtual TimeSlot? TimeSlot { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, MovieId: {MovieId}, RoomId: {RoomId}, TimeSlotId: {TimeSlotId}, StartDate: {StartDate}, EndDate: {EndDate}, Note: {Note}";
    }
}
