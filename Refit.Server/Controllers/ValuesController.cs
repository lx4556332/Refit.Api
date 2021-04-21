using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit.Client.Model;
using Refit.Server.interfaceApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Refit.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPersonsApi _api;
        public ValuesController(IPersonsApi api)
        {
            this._api = api;
        }

        // GET api/values
        [HttpGet]
        public async Task<List<Person>> GetAsync()
        {
            return await _api.GetPersonsAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Person> Get(int id)
        {
            return await _api.GetPersonAsync(id);
        }

        // POST api/values
        [HttpPost]
        public async Task<Person> Post([FromBody] Person value)
        {
            return await _api.AddPersonAsync(value);
        }
    }
}
