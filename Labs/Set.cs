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

        public Set(string Set)
        {
            try
            {
                this.Value = Set.Split(',').Select(float.Parse).ToList();
            }
            catch
            {
                this.Value = new List<float>();
            }
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

        public static List<Set> SetsRelation(Set set1, Set set2, Func<float, float, bool> selector)
        {
            var result = new List<Set>();

            foreach (var elem1 in set1.Value)
                foreach (var elem2 in set2.Value)
                    if (selector(elem1, elem2))
                        result.Add(new Set(elem1, elem2));

            return result;
        }

        public static Set CombineSets(Set set1, Set set2)
        {
            var result = set1;
            foreach(var elem in set2.Value)
            {
                result.Value.Add(elem);
            }

            return result;
        }

        public override string ToString()
        {
            return string.Join(',', Value);
        }
    }
}
