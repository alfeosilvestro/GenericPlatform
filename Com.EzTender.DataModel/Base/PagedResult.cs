using System;
using System.Collections.Generic;
using System.Text;

namespace Com.EzTender.DataModel.Base
{
    public class PagedResult<T> where T : GenericEntity
    {
        public int TotalRecords { get; set; }

        public int TotalPage { get; set; }

        public int CurrentPage { get; set; }

        public List<T> Records { get; set; }

    }
}
