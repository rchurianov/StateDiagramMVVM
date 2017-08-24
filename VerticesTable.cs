namespace StateDiagramMVVM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VerticesTable")]
    public partial class VerticesTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VerticesTable()
        {
            EdgesTable = new HashSet<EdgesTable>();
            EdgesTable1 = new HashSet<EdgesTable>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Vertex_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Vertex_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EdgesTable> EdgesTable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EdgesTable> EdgesTable1 { get; set; }

        public override string ToString()
        {
            return Vertex_Id.ToString() + " " + Vertex_Name;
        }
    }
}
