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
            animals.Add(new Animal(1, "Leão", "Panthera leo", "O leão é uma espécie de mamífero carnívoro do gênero Panthera e da família Felidae. A espécie é atualmente encontrada na África subsaariana e na Ásia, com uma única população remanescente em perigo, no Parque Nacional da Floresta de Gir, Gujarat, Índia"));
            animals.Add(new Animal(2, "Tigre", "Panthera tigris", "O tigre é um mamífero carnívoro da família dos felídeos, que habita o continente asiático. Dentre suas subespécies é o maior entre todos os felinos selvagens do mundo. São animais extremamente territoriais e solitário"));
            animals.Add(new Animal(3, "Crodilo", "Crocodylia", "Os crocodilos ou Crocodylidae são uma família de répteis com quatorze espécies. O termo 'crocodilo' também é usado às vezes num sentido mais amplo para se referir à ordem Crocodylia. Os crocodilos verdadeiros, os gaviais e os caimões, os aligatores e jacarés. Os crocodilos vivem nas Américas, África, Ásia e Austrália"));
            animals.Add(new Animal(4, "Elefante", "Elephantidae", "Elefante é o termo genérico e popular pelo qual são denominados os membros da família Elephantidae, um grupo de mamíferos proboscídeos elefantídeos, de grande porte, do qual há três espécies no mundo atual, duas africanas e uma asiática. Há ainda os mamutes, hoje extintos"));
            animals.Add(new Animal(5, "Girafa", "Giraffa", "A girafa é um mamífero artiodáctilo africano, o animal terrestre vivo mais alto e o maior ruminante. É tradicionalmente considerada uma espécie, Giraffa camelopardalis, com nove subespécies."));
            animals.Add(new Animal(6, "Macaco", "Primates", "Macaco é um termo de origem africana utilizado como designação comum a todas as espécies de símios ou primatas antropoides. É aplicada restritivamente no Brasil aos cebídeos em geral. No sentido estrito, 'macaco' refere-se às espécies de primatas pertencentes ao género Macaca. "));

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
