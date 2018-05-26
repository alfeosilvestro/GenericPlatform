using System;
using System.Collections.Generic;
using System.Text;

namespace Com.EzTender.ViewModels.Common
{
    public class OperationResult<T> where T : class
    {
        public OperationResult()
        {
        }

        public T ResultObject
        {
            get;
            set;
        }

        public bool IsSuccessful
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public Exception Error
        {
            get;
            set;
        }

        public int TotalPage { get; set; }

        public int TotalRecords { get; set; }

        public int CurrentPage { get; set; }

    }
}
