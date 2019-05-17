using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    public class OcrDrivingLicenceRequest : AbstractBaseRequest
    {
        /** 行驶证 */
        public static readonly int TYPE_VEHICLE_LICENSE = 0;
        /** 驾驶证 */
        public static readonly int TYPE_DRIVER_LICENSE = 1;

        public OcrDrivingLicenceRequest(String bucketName, int type, String url):base(bucketName)
        {
            //super(bucketName);
            isUrl = true;
            Url = url;
            Type = type;
        }

        //public OcrBizLicenseRequest(String bucketName, IFile image)
        //{
        //    super(bucketName);
        //    isUrl = false;
        //    image = image;
        //}

        public override void check_param()
        {
            base.check_param();
            //if (isUrl)
            //{
            //    CommonParamCheckUtils.AssertNotNull("url", url);
            //}
            //else
            //{
            //    CommonParamCheckUtils.AssertNotNull("image content", image);
            //}
        }

        public bool isUrl
        {
            get; set;
        }

        public String Url
        {
            get; set;
        }

        //public File getImage()
        //{
        //    return image;
        //}

        public int Type
        {
            get; set;
        }
    }
}
