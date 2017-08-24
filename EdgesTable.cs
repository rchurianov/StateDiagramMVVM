namespace StateDiagramMVVM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EdgesTable")]
    public partial class EdgesTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Edge_Id { get; set; }

        public int Start_Vertex_Id { get; set; }

        public int End_Vertex_Id { get; set; }

        public int Condition_Id { get; set; }

        public virtual ConditionsTable ConditionsTable { get; set; }

        public virtual VerticesTable VerticesTable { get; set; }

        public virtual VerticesTable VerticesTable1 { get; set; }

        public override string ToString()
        {
            return Edge_Id.ToString() + " " +
                Start_Vertex_Id.ToString() + " " +
                End_Vertex_Id.ToString() + " " +
                Condition_Id.ToString();
        }
    }
}
