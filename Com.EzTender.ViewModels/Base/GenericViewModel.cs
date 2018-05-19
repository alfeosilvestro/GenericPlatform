using System;

namespace Com.EzTender.ViewModels.Base
{
    public class GenericViewModel
    {
        
        public Guid RequestId { get; set; }
        public int RequestPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalRecords { get; set; }

        public int Id
        {
            get;
            set;
        }

        public DateTime CreatedDate
        {
            get;
            set;
        }

        public DateTime UpdatedDate
        {
            get;
            set;
        }

        public string CreatedBy
        {
            get;
            set;
        }

        public string UpdatedBy
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }

        public GenericViewModel()
        {
            this.RequestId = Guid.NewGuid();
        }

        public GenericViewModel(GenericViewModel requestObject)
        {
            this.RequestId = requestObject.RequestId;
        }
    }
}
