using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models;

public partial class View
{
    public int Id { get; set; }

    public String? RoomTitle { get; set; }

    public String? MovieTitle { get; set; }

    public String? TimeSlot { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Note { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {RoomTitle}, Movie: {MovieTitle}, TimeSlot: {TimeSlot}, StartDate: {StartDate}, EndDate: {EndDate}, Note: {Note}";
    }
}
