using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.FurnitureStore
{
    public abstract class Chair
    {
        protected Chair(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public override string ToString()
        {
            return $"{Title} | {Price.ToString("C")}";
        }

        public abstract void SitOn();
    }

    public class ModernChair : Chair
    {
        public ModernChair(string title, decimal price) : base(title, price)
        {
        }

        public override void SitOn()
        {
            Console.WriteLine("Sit on Modern Chair");
        }
    }
    public class VictorianChair : Chair
    {
        public VictorianChair(string title, decimal price) : base(title, price)
        {
        }

        public override void SitOn()
        {
            Console.WriteLine("Sit on Victorian Chair");
        }
    }
    public class ArtDecoChair : Chair
    {
        public ArtDecoChair(string title, decimal price) : base(title, price)
        {
        }

        public override void SitOn()
        {
            Console.WriteLine("Sit on ArtDeco Chair");
        }
    }
}
