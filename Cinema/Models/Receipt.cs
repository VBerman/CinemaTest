namespace Cinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            ReceiptService = new HashSet<ReceiptService>();
        }

        public int Id { get; set; }

        public int? ServiceId { get; set; }

        public DateTime? Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? ClientsId { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public virtual Clients Clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptService> ReceiptService { get; set; }
    }
}
