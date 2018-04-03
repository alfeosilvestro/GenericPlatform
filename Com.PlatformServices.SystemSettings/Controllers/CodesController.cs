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
        public async Task<string> Get(string keyword = "", int page = 1)
        {
            var result = await logic.GetCodesByPage(keyword, page);

            string jsonStringResult = JsonConvert.SerializeObject(result, 
                        Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

            return jsonStringResult;
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
