using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restapi.Data;
using Restapi.Models;

namespace Restapi.Controllers
{

    [Route("api/requests")]
    [ApiController]
    public class ApisController : ControllerBase
    {
        private readonly MockCommandsRepo _repository = new MockCommandsRepo();
        [HttpGet]
        public ActionResult<IEnumerable<apis>> GetData()
        {
            var items = _repository.GetData();
            return Ok(items);
        }
        [HttpGet("{id}")]
        public ActionResult<apis> GetDataById(int id)
        {
            var items = _repository.GetDataById(id);
            return Ok(items);

        }
    }
}