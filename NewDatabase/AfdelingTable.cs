namespace NewDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AfdelingTable")]
    public partial class AfdelingTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AfdelingTable()
        {
            UserTables = new HashSet<UserTable>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Navn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTable> UserTables { get; set; }
    }
}
