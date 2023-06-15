﻿using System.ComponentModel.DataAnnotations;

namespace SchedulerLoadOnDemand.Data
{
    public class AppointmentData
    {
        [Key]
        public int RecordId { get; set; }

        public int Id { get; set; }

        public string? Subject { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string? StartTimezone { get; set; }

        public string? EndTimezone { get; set; }

        public string? Location { get; set; }

        public string? Description { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool IsAllDay { get; set; } = false;

        public int? RecurrenceID { get; set; }

        public string? RecurrenceRule { get; set; }

        public string? RecurrenceException { get; set; }

        public bool? IsBlock { get; set; }
    }
}
