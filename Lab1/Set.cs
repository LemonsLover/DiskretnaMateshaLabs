using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    public class Set
    {
        public List<float> Value { get; set;}

        public Set(IEnumerable<float> Value)
        {
            this.Value = Value.ToList();
        }

        public Set(params float[] Values)
        {
            this.Value = Values.ToList();
        }

        public Set Union(Set set)
        {
            return new Set(Value.Union(set.Value));
        }

        public Set Intersect(Set set)
        {
            return new Set(Value.Intersect(set.Value));
        }

        public Set Defferance(Set set)
        {
            return new Set(Value.Except(set.Value));
        }

        public Set SymmetricDifference(Set set)
        {
            return new Set(this.Union(set).Value.Except(this.Intersect(set).Value));
        }
    }
}
