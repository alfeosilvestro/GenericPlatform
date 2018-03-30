using System;
namespace Com.PlatformServices.Common.FoundationClasses
{
    public class OperationResult<T> where T : BaseEntity
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
