using System;
using System.Collections.Generic;
using System.Text;

namespace Com.PlatformServices.Common.FoundationClasses
{
    public class BaseRequestModel
    {
        public DateTime RequestTimestamp { get; set; }
        public string RequestedByName { get; set; }
    }
}
