using VehicleDemo.Model;

namespace VehicleDemo.Service
{
    public class Servised : IServised
    {
        List<Car> carList = new List<Car>()
        {
            new Car(){Id=0,Color="red",Headlight=true,Whells=4},
            new Car(){Id=1,Color="blue",Headlight=true,Whells=4},
            new Car(){Id=2,Color="black",Headlight=true,Whells=4},
            new Car(){Id=3,Color="red",Headlight=true,Whells=4},
            new Car(){Id=4,Color="white",Headlight=true,Whells=4},
        };
        List<Bus> busList = new List<Bus>()
        {
            new Bus(){Id=0,Color="red"},
            new Bus(){Id=1,Color="blue"},
            new Bus(){Id=2,Color="black"},
            new Bus(){Id=3,Color="red"},
            new Bus(){Id=4,Color="white"},
        };
        List<Boat> boatList = new List<Boat>()
        {
            new Boat(){Id=0,Color="red"},
            new Boat(){Id=1,Color="blue"},
            new Boat(){Id=2,Color="black"},
            new Boat(){Id=3,Color="red"},
            new Boat(){Id=4,Color="white"},
        };
        public Vehicle SelectVehicle(string type, int id)
        {
            if(type == "Car")
            {
                var car = carList.Where(p => p.Id == id).FirstOrDefault();
                return car;
            }
            if (type == "Bus")
            {
                var bus = busList.Where(p => p.Id == id).FirstOrDefault();
                return bus;
            }
            if (type == "Boat")
            {
                var boat = boatList.Where(p => p.Id == id).FirstOrDefault();
                return boat;
            }
            return null;
        }
    }
}
