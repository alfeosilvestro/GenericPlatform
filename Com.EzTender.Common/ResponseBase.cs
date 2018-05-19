using System;
namespace Com.EzTender.Common
{
    public class ResponseBase<T> where T : class
    {
        /// <summary>
        /// Not preferred
        /// </summary>
        public ResponseBase()
        {
        }

        /// <summary>
        /// Recommened to initiate with App Identity
        /// </summary>
        /// <param name="identity">Identity.</param>
        public ResponseBase(AppIdentity identity)
        {
            this.ApplicationIdentity = identity;
        }

        public AppIdentity ApplicationIdentity { private set; get; }

        public T ResultObject { get; set; }
    }
}
