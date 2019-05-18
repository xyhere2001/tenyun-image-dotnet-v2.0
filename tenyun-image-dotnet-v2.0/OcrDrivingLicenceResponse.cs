using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    public class OcrDrivingLicenceResponse
    {
        public string code { get; set; }
        public string message { get; set; }
        public OcrDrivingLicencData data { get; set; }
    }

    public class OcrDrivingLicencData
    {
        public string session_id { get; set; }
        public List<OcrDrivingLicencItem> items { get; set; }
    }

    public class OcrDrivingLicencItem
    {
        public string item { get; set; }
        public string itemconf { get; set; }
        public string itemstring { get; set; }
    }
}
