namespace StateDiagramMVVM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StateDiagramModel : DbContext
    {
        public StateDiagramModel()
            : base("StateDiagramModel")
        {
        }

        public virtual DbSet<ConditionsTable> ConditionsTable { get; set; }
        public virtual DbSet<EdgesTable> EdgesTable { get; set; }
        public virtual DbSet<VerticesTable> VerticesTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConditionsTable>()
                .Property(e => e.Input)
                .IsUnicode(false);

            modelBuilder.Entity<ConditionsTable>()
                .Property(e => e.Output)
                .IsUnicode(false);

            modelBuilder.Entity<ConditionsTable>()
                .HasMany(e => e.EdgesTable)
                .WithRequired(e => e.ConditionsTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VerticesTable>()
                .Property(e => e.Vertex_Name)
                .IsUnicode(false);

            modelBuilder.Entity<VerticesTable>()
                .HasMany(e => e.EdgesTable)
                .WithRequired(e => e.VerticesTable)
                .HasForeignKey(e => e.End_Vertex_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VerticesTable>()
                .HasMany(e => e.EdgesTable1)
                .WithRequired(e => e.VerticesTable1)
                .HasForeignKey(e => e.Start_Vertex_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
