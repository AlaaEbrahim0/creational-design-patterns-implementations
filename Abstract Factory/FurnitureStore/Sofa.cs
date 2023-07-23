using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.FurnitureStore
{
    public interface ISofa
    {
        public void LayOn();
    }

    public class ModernSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Lay on Modern Sofa");
        }

    }

    public class VictorianSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Lay on Victorian Sofa");
        }

    }

    public class ArtDecoSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Lay on ArtDeco Sofa");
        }

    }
}
