using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    public class DetectionOp : BaseOp
    {
        private static readonly string HTTP = "http://";
        private static readonly string HTTPS = "https://";

        public DetectionOp(ClientConfig config, Credentials cred) : base(config, cred)//, AbstractImageHttpClient client) : base(config, cred, client)
        {
            //super(config, cred, client);
        }

        private string getProtocol()
        {
            return config.isEnableHttps() ? HTTPS : HTTP;
        }

        /**
     * OCR-行驶证驾驶证识别
     * 
     * @param request 标签识别请求参数
     * @return JSON格式的字符串, 格式为{"code":$code, "message":"$mess"}, code为0表示成功, 其他为失败,
     *         message为success或者失败原因
     * @throws AbstractImageException SDK定义的Image异常, 通常是输入参数有误或者环境问题(如网络不通)
     */
        public string ocrDrivingLicence(OcrDrivingLicenceRequest request)
        {
            //request.check_param();

            //String sign = Sign.appSign(cred, request.BucketName, this.config.getSignExpired());
            //String url = getProtocol() + this.config.getQCloudImageDomain() + OCR_DRIVINGLICENCE;

            //HttpRequest httpRequest = new HttpRequest();
            //httpRequest.setMethod(HttpMethod.POST);
            //httpRequest.setUrl(url);
            //httpRequest.addHeader(RequestHeaderKey.Authorization, sign);
            //httpRequest.setContentType(HttpContentType.APPLICATION_JSON);
            //httpRequest.addParam(RequestBodyKey.APPID, String.valueOf(cred.getAppId()));
            //httpRequest.addParam(RequestBodyKey.BUCKET, request.getBucketName());
            //httpRequest.addParam("type", request.getType());
            //if (request.isUrl)
            //{
            //    httpRequest.addHeader(RequestHeaderKey.Content_TYPE, String.valueOf(HttpContentType.APPLICATION_JSON));
            //    httpRequest.addParam(RequestBodyKey.URL, request.getUrl());
            //    httpRequest.setContentType(HttpContentType.APPLICATION_JSON);
            //}
            //else
            //{
            //    httpRequest.setContentType(HttpContentType.MULTIPART_FORM_DATA);
            //    httpRequest.addFile("image", request.getImage());
            //}
            //return httpClient.sendHttpRequest(httpRequest);
            return "";
        }
    }
}
