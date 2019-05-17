using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    public class ImageClient : Image
    {
        private ClientConfig config;
        private Credentials cred;
        //private AbstractImageHttpClient client;

        private DetectionOp detectionOp;

        /** 老域名 */
        public static readonly string OLD_DOMAIN_service_image_myqcloud_com = "service.image.myqcloud.com";
        /** 新域名 */
        public static readonly string NEW_DOMAIN_recognition_image_myqcloud_com = "recognition.image.myqcloud.com";

        /**
         * @param domain {@link #OLD_DOMAIN_service_image_myqcloud_com} or {@link #NEW_DOMAIN_recognition_image_myqcloud_com}
         */
        public ImageClient(String appId, String secretId, String secretKey, String domain) : this(new Credentials(appId, secretId, secretKey))
        {
            //(new Credentials(appId, secretId, secretKey));
            ClientConfig.QCLOUD_IMAGE_DOMAIN = domain;
        }

        public ImageClient(Credentials cred) : this(new ClientConfig(), cred)
        {
            //this(new ClientConfig(), cred);
        }

        /**
         * 设置是否使用 HTTPS 协议. 此方法非必选, 默认使用 HTTPS<br>
         * 为保证信息安全, 推荐使用 HTTPS
         * @param enableHttps true: HTTPS, false: HTTP. 默认为 true
         */
        public void setEnableHttps(bool enableHttps)
        {
            this.config.setEnableHttps(enableHttps);
        }

        public void setConfig(ClientConfig config)
        {
            this.config = config;
            this.detectionOp.setConfig(config);
            //this.client.shutdown();
            //this.client = new DefaultImageHttpClient(config);
            //this.detectionOp.setHttpClient(this.client);
        }

        public void setCred(Credentials cred)
        {
            this.cred = cred;
            this.detectionOp.setCred(cred);
        }

        //public void setProxy(Proxy proxy)
        //{
        //    this.config.setProxy(proxy);
        //}

        public ImageClient(ClientConfig config, Credentials cred)
        {
            this.config = config;
            this.cred = cred;
            //this.client = new DefaultImageHttpClient(config);
            detectionOp = new DetectionOp(this.config, this.cred);//, this.client);
        }

        public string ocrDrivingLicence(OcrDrivingLicenceRequest request)
        {
            return detectionOp.ocrDrivingLicence(request);
        }

        public void shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
