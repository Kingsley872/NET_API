using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWheelsAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CWheelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : Controller
    {
        private static List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle() {Id = 0, Title = "Tesla S", Price = 23000},
            new Vehicle() {Id = 1, Title = "Tesla X", Price = 29000},
        };

        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return vehicles;	
		}

        /*
            on postman 
            create a new request
            Post  AND https://localhost:5001/api/Vehicles
            under body -> raw -> text -> JSON
                {
                    "id":1,
                    "Title":"Tesla Z",
                    "Price":23000
                }
            Send
		*/
        [HttpPost]
        public void Post([FromBody]Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        /*
            on postman 
            create a new request
            PUT AND https://localhost:5001/api/Vehicles/1   the 1 is the id represents to the id that is going to be modifiled 
            under body -> raw -> text -> JSON
                {
                    "id":1,
                    "Title":"Tesla Z",
                    "Price":23000
                }
            Send
		*/

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Vehicle vehicle)
        {
            vehicles[id] = vehicle;
		}

        /*
            on postman 
            create a new request
            DELTE AND https://localhost:5001/api/Vehicles/1   the 1 is the id represents to the id that is going to be modifiled 
            Send
        */

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            vehicles.RemoveAt(id);
		}
            

        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
