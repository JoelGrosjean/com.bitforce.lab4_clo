namespace com.bitforce.lab4_clo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activity()
        {
            Events = new HashSet<Event>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Website { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public decimal Cost { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }
    }
}
