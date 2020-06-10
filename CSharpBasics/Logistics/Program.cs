using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogistics ship = new SeaLogistic();
            ship.Transport();
            ILogistics container = new RoadLogistics();
            container.Transport();
            Console.ReadLine();
        }
    }
    public class ILogistics
    {
        public void Transport()
        {
            Console.WriteLine("Transportation");
        }
    }
    public class SeaLogistic : ILogistics
    {
        public void Transport()
        {
            Console.WriteLine("Transportation through sea");
        }

    }
    public class RoadLogistics : ILogistics
    {
        public void Transport()
        {
            Console.WriteLine("Transportation through Road");
        }
    }
}
