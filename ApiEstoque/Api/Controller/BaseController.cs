using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<M, R> : ControllerBase where M : Base where R : BaseRepository<M>
    {
        R repository;

        public BaseController(R repo)
        {
            this.repository = repo;
        }
        [HttpGet]
        public List<M> Get()
        { 
            return repository.Read();

        }

        [HttpGet("{id}")]
        public M Get(int id)
        {
            return repository.Read(id);
        }

        [HttpPost]
        public void Post([FromBody] M model)
        {
            repository.Create(model);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] M model)
        {
            repository.Update(model);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
