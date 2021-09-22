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
    public class NewsController : ControllerBase
    {
        // GET: api/<AnimalController>
        [HttpGet]
        public List<News> Get()
        {
            List<News> news = new List<News>();
            news.Add(new News(1, "Estudo inédito faz levantamento de insetos aquáticos em área ambiental no interior do Acre", "Camarão de água doce, mosquitos, borboletas de piracema, siriruias, sararás ou besouros-de-maio, libélula, mosca-d’água ou mosca-tiririca, besouros e percevejos. Estes foram alguns dos insetos aquáticos identificados em uma pesquisa inédita no Acre que é desenvolvida por professores e alunos do curso de Ciências Biológicas do Instituto Federal do Acre (Ifac)."));

            return news;
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
