using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.FurnitureStore
{
    public interface ICoffeeTable
    {
        public void DrinkOn();
    }
    public class ModernCoffeeTable : ICoffeeTable
    {
        public void DrinkOn()
        {
            Console.WriteLine("Modern Coffee Table");
        }
    }
    public class VictorainCoffeeTable : ICoffeeTable
    {
        public void DrinkOn()
        {
            Console.WriteLine("Victorain Coffee Table");
        }
    }
    public class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void DrinkOn()
        {
            Console.WriteLine("ArtDeco Coffee Table");
        }
    }
}
