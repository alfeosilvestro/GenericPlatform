using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Com.PlatformServices.BudgetMetal.Configurations;
using Com.PlatformServices.BudgetMetal.Repository;
using Com.PlatformServices.Common.DAL.Entities.SystemSettings;
using Com.PlatformServices.Common.FoundationClasses;
using Newtonsoft.Json;
using Com.PlatformServices.BudgetMetal.Logic;
using Com.PlatformServices.BudgetMetal.Requests;
using System.IO;

namespace Com.PlatformServices.BudgetMetal.Controllers
{
    [Route("api/[controller]")]
    public class GalleriesController : Controller
    {
        private readonly IGalleriesLogic logic;

        public GalleriesController(IGalleriesLogic logic)
        {
            this.logic = logic;
        }

        // GET api/values
        [HttpGet("test")]
        public async Task<JsonResult> test(string keyword = "", int page = 1)
        {
            var result = page;

            return new JsonResult(result, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        // GET api/values
        [HttpGet]
        public async Task<JsonResult> Get(string keyword = "", int page = 1)
        {
            var result = await logic.GetGalleriesByPage(keyword, page);

            return new JsonResult(result, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int id)
        {
            var result = await logic.GetGalleryById(id);

            return new JsonResult(result, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        // GET api/values/5
        [HttpGet("download/{id}")]
        public async Task<FileResult> Download(int id)
        {
            var bm_gallery = await logic.GetGalleryById(id);
            //var bm_gallery = await _context.bm_gallery
            //    .SingleOrDefaultAsync(m => m.Id == fileid);
            if (bm_gallery == null)
            {
                return null;
            }

            var fileByeArray = bm_gallery.ResultObject.ResultObject.DownloadableImage;
            string fileName = (bm_gallery.ResultObject.ResultObject.Name).Replace(" ", "_").Trim() + ".zip";
            var readStream = new MemoryStream(Convert.FromBase64String(fileByeArray));
            var mimeType = "application/zip";
            return File(readStream, mimeType, fileName);
        }

        // GET api/values/5
        [HttpGet("active")]
        public JsonResult GetActiveGallery()
        {
            var result = logic.GetActiveGallery();

            return new JsonResult(result, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromForm]GalleriesRequestModel value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromForm]GalleriesRequestModel value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
