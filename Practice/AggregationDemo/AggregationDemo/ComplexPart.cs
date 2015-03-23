using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    abstract class ComplexPart : IComplexPart
    {
        public string Name { get; set; }
        public List<IPart> Parts { get; set; }
        public virtual void TightenParts()
        {
            // Tighten all tightenable parts
            foreach (IPart part in Parts.Where(part => part.InheritsFromInterface(typeof(ITightenable))))
            {
                bool tightened = ((ITightenable)part).Tighten();
                Console.WriteLine("Part: {0} was tightened: {1}\n", part.Name, tightened);
            }
            // Tighten all complex parts
            foreach (IPart part in Parts.Where(part => part.InheritsFromInterface(typeof (IComplexPart))))
            {
                ((IComplexPart)part).TightenParts();
            }
        }

        public abstract void CreateParts();

        protected ComplexPart()
        {
            Parts = new List<IPart>();
            CreateParts();
        }
    }
}
