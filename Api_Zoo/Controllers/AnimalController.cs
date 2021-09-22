using Api_Zoo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {



        // GET: api/<AnimalController>
        [HttpGet]
        public List<Animal> Get()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(1, "Leão", "", ""));
            animals.Add(new Animal(2, "Tigre", "", ""));
            animals.Add(new Animal(3, "Crodilo", "", ""));
            animals.Add(new Animal(4, "Elefante", "", ""));
            animals.Add(new Animal(5, "Girafa", "", ""));
            animals.Add(new Animal(6, "Macaco", "", ""));

            return animals;
        }

        // GET api/<AnimalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AnimalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AnimalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnimalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
