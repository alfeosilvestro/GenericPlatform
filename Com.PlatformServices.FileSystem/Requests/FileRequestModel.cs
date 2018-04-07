using Com.PlatformServices.Common.FoundationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.FileSystem.Requests
{
    public class FileRequestModel : BaseRequestModel
    {
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string OriginalFileName { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string FileExtension { get; set; }
        public string FileContent { get; set; }
        public string ApplicationId { get; set; }
    }
}
