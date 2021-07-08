using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using SampleWebApi.Interfaces;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    [RoutePrefix("api/todo")]
    public class TodoController : ApiController
    {
        private readonly IListService _listService;

        public TodoController(IListService listService)
        {
            _listService = listService;
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<ListEntity> GetList(string name)
        {
            return await _listService.GetList(name);
        }

        [HttpPost]
        [Route()]
        public async Task SaveList(ListEntity listEntity)
        {
            await _listService.SaveList(listEntity);
        }
    }
}