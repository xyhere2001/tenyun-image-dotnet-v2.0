using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    public class ClientConfig
    {
        // 多次签名的默认过期时间,单位秒
        private static readonly int DEFAULT_SIGN_EXPIRED = 300;
        // 默认的最大重试次数(发生了socketException时)
        private static readonly int DEFAULT_MAX_RETRIES = 3;
        // 默认的获取连接的超时时间
        private static readonly int DEFAULT_CONNECTION_REQUEST_TIMEOUT = 60 * 1000;
        // 默认连接超时, 单位ms
        private static readonly int DEFAULT_CONNECTION_TIMEOUT = 60 * 1000;
        // 默认的SOCKET读取超时时间, 默认毫秒
        private static readonly int DEFAULT_SOCKET_TIMEOUT = 60 * 1000;
        // 默认的维护最大HTTP连接数
        private static readonly int DEFAULT_MAX_CONNECTIONS_COUNT = 100;
        // 默认的user_agent标识
        private static readonly string DEFAULT_USER_AGENT = "image-java-sdk-v2.3.0";

        public static string QCLOUD_IMAGE_DOMAIN = "service.image.myqcloud.com";

        //黄图识别服务api
        private static readonly string DETECTION_PORN = "/detection/porn_detect";
        //最大的识别限制
        private static readonly int MAX_DETECTION_NUM = 20;
        //最大的列表限制
        private static readonly int MAX_LIST_NUM = 20;

        //标签识别服务api
        private static readonly string DETECTION_TAG = "/v1/detection/imagetag_detect";

        //身份证识别服务api
        private static readonly string DETECTION_IDCARD = "/ocr/idcard";

        //名片识别服务api
        private static readonly string DETECTION_NAMECARD = "/ocr/businesscard";

        /** 行驶证驾驶证识别 */
        public static readonly string OCR_DRIVINGLICENCE = "/ocr/drivinglicence";
        /** 车牌号识别 */
        public static readonly string OCR_PLATE = "/ocr/plate";
        /** 银行卡识别 */
        public static readonly string OCR_BANKCARD = "/ocr/bankcard";
        /** 营业执照识别 */
        public static readonly string OCR_BIZLICENSE = "/ocr/bizlicense";
        /** 通用印刷体识别 */
        public static readonly string OCR_GENERAL = "/ocr/general";

        //人脸识别服务api
        private static readonly string DETECTION_FACE = "/face/detect";

        //人脸定位服务api
        private static readonly string FACE_SHAPE = "/face/shape";

        //个体创建api
        private static readonly string FACE_NEW_PERSON = "/face/newperson";

        //个体删除api
        private static readonly string FACE_DEL_PERSON = "/face/delperson";

        //增加人脸api
        private static readonly string FACE_ADD_FACE = "/face/addface";

        //人脸删除api
        private static readonly string FACE_DEL_FACE = "/face/delface";

        //个体设置信息api
        private static readonly string FACE_SET_INFO = "/face/setinfo";

        //个体获取信息api
        private static readonly string FACE_GET_INFO = "/face/getinfo";

        //获取组列表api
        private static readonly string FACE_GET_GROUPIDS = "/face/getgroupids";

        //获取人列表api
        private static readonly string FACE_GET_PERSONIDS = "/face/getpersonids";

        //获取人脸列表api
        private static readonly string FACE_GET_FACEIDS = "/face/getfaceids";

        //获取人脸信息api
        private static readonly string FACE_GET_FACEINFO = "/face/getfaceinfo";

        //人脸识别api
        private static readonly string FACE_IDENTIFY = "/face/identify";

        //人脸验证api
        private static readonly string FACE_VERIFY = "/face/verify";

        //人脸对比api
        private static readonly string FACE_COMPARE = "/face/compare";

        //身份证识别对比api
        private static readonly string FACE_IDCARD_COMPARE = "/face/idcardcompare";

        //获取验证码api
        private static readonly string FACE_LIVE_GET_FOUR = "/face/livegetfour";

        //检测api
        private static readonly string FACE_LIVE_DETECT_FOUR = "/face/livedetectfour";

        //对比指定身份信息api
        private static readonly string FACE_IDCARD_LIVE_DETECT_FOUR = "/face/idcardlivedetectfour";

        private int signExpired = DEFAULT_SIGN_EXPIRED;
        private int maxFailedRetry = DEFAULT_MAX_RETRIES;
        private int connectionRequestTimeout = DEFAULT_CONNECTION_REQUEST_TIMEOUT;
        private int connectionTimeout = DEFAULT_CONNECTION_TIMEOUT;
        private int socketTimeout = DEFAULT_SOCKET_TIMEOUT;
        private int maxConnectionsCount = DEFAULT_MAX_CONNECTIONS_COUNT;
        private string userAgent = DEFAULT_USER_AGENT;
        //private Proxy mProxy;
        private bool mEnableHttps = true;

        public void setEnableHttps(bool enableHttps)
        {
            mEnableHttps = enableHttps;
        }

        public bool isEnableHttps()
        {
            return mEnableHttps;
        }

        //public void setProxy(Proxy proxy)
        //{
        //    mProxy = proxy;
        //}

        //public Proxy getProxy()
        //{
        //    return mProxy;
        //}

        public int getMaxFailedRetry()
        {
            return maxFailedRetry;
        }

        public void setMaxFailedRetry(int maxFailedRetry)
        {
            this.maxFailedRetry = maxFailedRetry;
        }

        public int getSignExpired()
        {
            return signExpired;
        }

        public void setSignExpired(int signExpired)
        {
            this.signExpired = signExpired;
        }

        public int getConnectionRequestTimeout()
        {
            return connectionRequestTimeout;
        }

        public void setConnectionRequestTimeout(int connectionRequestTimeout)
        {
            this.connectionRequestTimeout = connectionRequestTimeout;
        }

        public int getConnectionTimeout()
        {
            return connectionTimeout;
        }

        public void setConnectionTimeout(int connectionTimeout)
        {
            this.connectionTimeout = connectionTimeout;
        }

        public int getSocketTimeout()
        {
            return socketTimeout;
        }

        public void setSocketTimeout(int socketTimeout)
        {
            this.socketTimeout = socketTimeout;
        }

        public int getMaxConnectionsCount()
        {
            return maxConnectionsCount;
        }

        public void setMaxConnectionsCount(int maxConnectionsCount)
        {
            this.maxConnectionsCount = maxConnectionsCount;
        }

        public string getUserAgent()
        {
            return userAgent;
        }

        public void setUserAgent(string userAgent)
        {
            this.userAgent = userAgent;
        }

        public string getQCloudImageDomain()
        {
            return QCLOUD_IMAGE_DOMAIN;
        }

        public string getDetectionPorn()
        {
            return DETECTION_PORN;
        }

        public static int getMaxDetectionNum()
        {
            return MAX_DETECTION_NUM;
        }

        public static int getMaxListNum()
        {
            return MAX_LIST_NUM;
        }

        public string getDetectionTag()
        {
            return DETECTION_TAG;
        }

        public string getDetectionIdcard()
        {
            return DETECTION_IDCARD;
        }

        public string getDetectionNamecard()
        {
            return DETECTION_NAMECARD;
        }

        public string getDetectionFace()
        {
            return DETECTION_FACE;
        }

        public string getFaceShape()
        {
            return FACE_SHAPE;
        }

        public string getFaceNewPerson()
        {
            return FACE_NEW_PERSON;
        }

        public string getFaceDelPerson()
        {
            return FACE_DEL_PERSON;
        }

        public string getFaceAddFace()
        {
            return FACE_ADD_FACE;
        }

        public string getFaceDelFace()
        {
            return FACE_DEL_FACE;
        }

        public string getFaceSetInfo()
        {
            return FACE_SET_INFO;
        }

        public string getFaceGetInfo()
        {
            return FACE_GET_INFO;
        }

        public string getFaceGetGroupIdsInfo()
        {
            return FACE_GET_GROUPIDS;
        }

        public string getFaceGetPersonIdsInfo()
        {
            return FACE_GET_PERSONIDS;
        }

        public string getFaceGetFaceIdsInfo()
        {
            return FACE_GET_FACEIDS;
        }

        public string getFaceGetFaceInfo()
        {
            return FACE_GET_FACEINFO;
        }

        public string getFaceIdentify()
        {
            return FACE_IDENTIFY;
        }

        public string getFaceVerify()
        {
            return FACE_VERIFY;
        }

        public string getFaceCompare()
        {
            return FACE_COMPARE;
        }

        public string getFaceIdcardCompare()
        {
            return FACE_IDCARD_COMPARE;
        }

        public string getFaceLiveGetFour()
        {
            return FACE_LIVE_GET_FOUR;
        }

        public string getFaceLiveDetectFour()
        {
            return FACE_LIVE_DETECT_FOUR;
        }

        public string getFaceIdCardLiveDetectFour()
        {
            return FACE_IDCARD_LIVE_DETECT_FOUR;
        }
    }
}
