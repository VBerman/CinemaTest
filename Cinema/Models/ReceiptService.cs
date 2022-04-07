namespace Cinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptService")]
    public partial class ReceiptService
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? ServiceId { get; set; }

        public int? ReceiptId { get; set; }

        public int? Quantity { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Service Service { get; set; }
    }
}
