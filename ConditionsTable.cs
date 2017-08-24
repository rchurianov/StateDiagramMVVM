namespace StateDiagramMVVM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConditionsTable")]
    public partial class ConditionsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConditionsTable()
        {
            EdgesTable = new HashSet<EdgesTable>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Condition_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Input { get; set; }

        [Required]
        [StringLength(50)]
        public string Output { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EdgesTable> EdgesTable { get; set; }

        public override string ToString()
        {
            return Condition_Id.ToString() + " " +
                Input.ToString() + " " +
                Output.ToString();
        }
    }
}
