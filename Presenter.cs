using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDiagramMVVM
{
    /* ViewModel class
     */
    public class Presenter : ObservableObject
    {
        StateDiagramModel model = new StateDiagramModel();

        private List<VerticesTable> _vertices;
        private List<EdgesTable> _edges;
        private List<ConditionsTable> _conditions;

        public Presenter()
        {
            PopulateVertices();
            PopulateEdges();
            PopulateConditions();
        }

        private void PopulateConditions()
        {
            var q = (from e in model.EdgesTable select e).ToList();
            this.Edges = q;
        }

        private void PopulateEdges()
        {
            var q = (from c in model.ConditionsTable select c).ToList();
            this.Conditions = q;
        }

        private void PopulateVertices()
        {
            var q = (from v in model.VerticesTable select v).ToList();
            this.Vertices = q;
        }

        public List<VerticesTable> Vertices
        {
            get
            {
                return _vertices;
            }

            set
            {
                _vertices = value;
                RaisePropertyChanged("Vertices");
            }
        }

        public List<EdgesTable> Edges
        {
            get
            {
                return _edges;
            }

            set
            {
                _edges = value;
                RaisePropertyChanged("Edges");
            }
        }

        public List<ConditionsTable> Conditions
        {
            get
            {
                return _conditions;
            }

            set
            {
                _conditions = value;
                RaisePropertyChanged("Conditions");
            }
        }

    }
}
