using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly IFileSystemLogic logic;

        public FilesController(IFileSystemLogic logic)
        {
            this.logic = logic;
        }

        // GET api/values
        [HttpGet]
        public async Task<string> Get(string keyword = "", int page = 1)
        {
            var result = await logic.GetFilesByPage(keyword, page);

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
        public async Task<FileStreamResult> Get(int id)
        {
            var result = await logic.GetFileById(id);

            if (result.IsSuccessful && result.ResultObject != null)
            {
                byte[] data = System.Convert.FromBase64String(result.ResultObject.FileContent);
                Stream stream = new MemoryStream(data);
                string downloadFileName = result.ResultObject.FileName + "." + result.ResultObject.FileExtension;
                var response = File(stream, "application/octet-stream", downloadFileName); // FileStreamResult
                return response;
            }
            else
            {
                return null;
            }
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
        public async Task Delete(int id)
        {
            var result = logic.DeleteFileById(id);
        }
    }
}
