using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VehicleDemo.Model;
using VehicleDemo.Service;

namespace VehicleDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IServised _servised;

        public VehicleController(IServised servised)
        {
            this._servised = servised;
        }
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

        [HttpGet  ("[action]")]
        public IActionResult GetAllCar()
        {
            
            return Ok(carList);
        }

        [HttpGet("[action]/{color}")]
        public IActionResult GetAllCar(string color)
        {
            var carColorList=carList.Where(p => p.Color == color).ToList();
            return Ok(carColorList);
        }

        [HttpGet("[action]")]
        public IActionResult GetAllBus()
        {

            return Ok(busList);
        }

        [HttpGet("[action]")]
        public IActionResult GetAllBoat()
        {

            return Ok(boatList);
        }

        [HttpPost("[action]/{id}")]
        public IActionResult changeHeadlight(int id)
        {
            var car = carList.Find(p => p.Id == id);
            car.Headlight = !car.Headlight;
            
            carList[id] = car;

            return Ok(car);
        }

        [HttpDelete("[action]/{id}")]
        public IActionResult deleteVehicle(int id)
        {

            var car = carList.Find(p => p.Id == id);
            carList.Remove(car);
            

            return Ok(carList);
        }

        [HttpGet("[action]/{type}/{id}")]
        public IActionResult GetVehicle(string type,int id)
        {
            Vehicle vehicle=_servised.SelectVehicle(type,id);
            return Ok(vehicle);
            
        }


    }
}
