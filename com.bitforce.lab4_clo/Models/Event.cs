namespace com.bitforce.lab4_clo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ServiceAreaId { get; set; }

        public bool Completed { get; set; }

        public int Activity_Id { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual ServiceArea ServiceArea { get; set; }
    }
}
