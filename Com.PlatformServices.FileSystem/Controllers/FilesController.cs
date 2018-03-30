using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.PlatformServices.Common.DAL.Entities.FileSystem;
using Com.PlatformServices.Common.FoundationClasses;
using Com.PlatformServices.FileSystem.Configurations;
using Com.PlatformServices.FileSystem.Logic;
using Com.PlatformServices.FileSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Com.PlatformServices.FileSystem.Controllers
{
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        private readonly AppSettings config;
        private readonly IFileSystemLogic logic;

        public FilesController(IFileSystemLogic logic)
        {
            this.logic = logic;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            var result = logic.GetFilesByPage("", 1);

            string jsonStringResult = JsonConvert.SerializeObject(result,
                        Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });

            return jsonStringResult;

            //return new string[] { "value1", "value2" };
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
