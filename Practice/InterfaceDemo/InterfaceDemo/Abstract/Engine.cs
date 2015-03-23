using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Abstract
{
    class Engine : IEngine
    {
        public object PartName { get; set; }
        public IList<IPart> Parts { get; set; }

        public void TightenAllBolts()
        {
            foreach (var bolt in Parts.OfType<IBolt>())
            {
                bolt.Tighten();
            }
            foreach(var bolt in Parts.OfType<IComplexPart>()
                .SelectMany(cpart => cpart.Parts.OfType<IBolt>()))
            {
                bolt.Tighten();
            }
        }

        public void TightenEverything()
        {
            foreach (var tightenable in Parts.OfType<ITightenable>())
            {
                tightenable.Tighten();
            }
            foreach (var tightenable in Parts.OfType<IComplexPart>()
                .SelectMany(cpart => cpart.Parts.OfType<ITightenable>())) {
                tightenable.Tighten();
            }
        }

        public string EngineType { get; set; }
    }
}
