namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public long ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public bool? status { get; set; }
    }
}
