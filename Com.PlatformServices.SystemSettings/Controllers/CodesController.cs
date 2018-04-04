using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Com.PlatformServices.SystemSettings.Configurations;
using Com.PlatformServices.SystemSettings.Repository;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.FoundationClasses;
using Newtonsoft.Json;
using Com.PlatformServices.SystemSettings.Logic;
using Com.PlatformServices.SystemSettings.Requests;

namespace Com.PlatformServices.SystemSettings.Controllers
{

    [Route("api/[controller]")]
    public class CodesController : Controller
    {
        private readonly ICodesLogic logic;

        public CodesController(ICodesLogic logic)
        {
            this.logic = logic;
        }

        // GET api/values
        [HttpGet]
        public async Task<JsonResult> Get(string keyword = "", int page = 1)
        {
            var result = await logic.GetCodesByPage(keyword, page);

            return new JsonResult(result, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int id)
        {
            var result = await logic.GetCodeById(id);

            return new JsonResult(result, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        // GET api/values/5
        [HttpGet("{parentId}/children")]
        public JsonResult GetChildren(int parentId)
        {
            var result = logic.GetCodesByParentId(parentId);

            return new JsonResult(result, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromForm]CodesRequestModel value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromForm]CodesRequestModel value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
