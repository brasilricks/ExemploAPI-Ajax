using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testeProg.Controllers
{
    public class DadosController : ApiController
    {
        private static List<Rick_and_Morty_API> dados = new List<Rick_and_Morty_API>();

        //// GET: api/Dados
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Dados/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [HttpGet]
        public List<Rick_and_Morty_API> Get()
        {
            return dados;
        }

        // POST: api/Dados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dados/5
        public void Delete(int id)
        {
        }
    }
}
