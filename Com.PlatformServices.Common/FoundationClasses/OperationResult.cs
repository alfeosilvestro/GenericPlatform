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
    }
}
