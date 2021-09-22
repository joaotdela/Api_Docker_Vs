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
    public class ZooController : ControllerBase
    {
            // GET: api/<AnimalController>
        [HttpGet]
        public List<Zoo> Get()
        {
            List<Zoo> zoo = new List<Zoo>();
            zoo.Add(new Zoo(1, "Parque Zoológico de São Paulo", "O Parque Zoológico de São Paulo, localizado na Zona Sul da cidade, é o maior jardim zoológico do Brasil. Abriga as nascentes do histórico riacho do Ipiranga, ao sul da cidade de São Paulo, localizado em uma área de 824 529 metros quadrados de Mata Atlântica original, com quatro quilômetros de alamedas", "Segunda a Segunda das 09:00 as 17:00"));
            zoo.Add(new Zoo(2, "Zoo Safári", "O Zoo Safári é um parque zoológico localizado na região sudeste da cidade de São Paulo, no distrito do Cursino. O diferencial deste parque é que o visitante pode interagir com os animais de dentro do carro, para isso o passeio é realizado em veículos que podem ser alugados no local ou em veículo próprio. ", "Segunda a Segunda das 10:00 as 16:00"));
            zoo.Add(new Zoo(3, "Zoo Foz", "", "Segunda a Sábado das 09:00 a 17:00"));
            return zoo;
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
