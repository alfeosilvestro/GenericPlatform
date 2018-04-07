using System;
using System.Collections.Generic;
using System.Text;

namespace Com.PlatformServices.Common.FoundationClasses
{
    public class PagedResult<T> where T : BaseEntity
    {
        public int TotalRecords { get; set; }

        public int TotalPage { get; set; }

        public int CurrentPage { get; set; }

        public List<T> Records { get; set; }

    }
}
