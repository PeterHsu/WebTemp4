using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data.SqlClient;

namespace Backend.Controllers
{
    public class Trader
    {
        public string TraderId { get; set; }
        public string Account { get; set; }
    }
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Trader> Get()
        {
            SqlConnection conn = new SqlConnection("Data Source=172.24.26.39;Initial Catalog=Trade_DB;User Id=it;Password=it;");
            return conn.Query<Trader>("Select [TraderId],[Account] from tssTraders");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
