using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.FurnitureStore
{
    public interface IFamilyFactory
    {
        public Chair CreateChair();
        public ICoffeeTable CreateCoffeeTable();
        public ISofa CreateSofa();
    }

    public class ModernFamilyFactory : IFamilyFactory
    {
        public Chair CreateChair()
        {
            return new ModernChair("Minimalisic Chair", 100m);
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

    }
    public class VictorianFamilyFactory : IFamilyFactory
    {
        public Chair CreateChair()
        {
            return new VictorianChair("Ancient Chair", 100m);
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorainCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
    public class ArtDecoFamilyFactory : IFamilyFactory
    {
        public Chair CreateChair()
        {
            return new ArtDecoChair("Artistic Chair", 350m);
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }


}
