using Com.PlatformServices.Common.FoundationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.SystemSettings.Requests
{
    public class CodesRequestModel : BaseRequestModel
    {
        public int Id { get; set; }
        public int ParentCodeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
