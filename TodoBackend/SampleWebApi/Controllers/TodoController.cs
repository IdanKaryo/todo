using System.Collections.Generic;
using System.Web.Http;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    [RoutePrefix("api/todo")]
    public class TodoController : ApiController
    {

        public TodoController()
        {
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            List<TodoEntity> result = new List<TodoEntity>()
            {
                new TodoEntity(){Text = "Example Task 1"},
                new TodoEntity(){Text = "Example Task 2"},
            };

            return Ok(result);
        }
    }
}