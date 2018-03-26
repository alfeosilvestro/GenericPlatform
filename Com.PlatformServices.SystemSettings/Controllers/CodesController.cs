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

namespace Com.PlatformServices.SystemSettings.Controllers
{

    [Route("api/[controller]")]
    public class CodesController : Controller
    {
        private readonly AppSettings config;
        private readonly ICodeRepository repo;

        public CodesController(IOptions<AppSettings> config, ICodeRepository repo)
        {
            this.config = config.Value;
            this.repo = repo;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            var dbResult = repo.GetAll();

            ResponseBase<IEnumerable<Sys_Setting_Code>> result = new ResponseBase<IEnumerable<Sys_Setting_Code>>(config.App_Identity);
            result.ResultObject = dbResult;

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
