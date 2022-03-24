using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiForTraining.Data;
using WebApiForTraining.Model;

namespace WebApiForTraining.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IContract _repository;
        public PersonController( IContract repository)
        {
            _repository = repository;
                
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllData() {
            var response =  _repository.GetAllData();
            if (response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetDataById(int id) {
            var reponse = _repository.GetUserById(id);
            if (reponse == null)
                return NotFound();
            return Ok(reponse);
        }
        [HttpPost]
        public ActionResult CreateData(User user) {
            _repository.CreateUser(user);
            _repository.SaveChanges();
            return Ok();
        }
       
    }
}
