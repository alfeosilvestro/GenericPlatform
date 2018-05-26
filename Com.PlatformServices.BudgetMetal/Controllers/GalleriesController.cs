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
