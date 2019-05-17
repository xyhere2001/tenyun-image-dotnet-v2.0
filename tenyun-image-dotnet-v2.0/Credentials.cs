using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    /// <summary>
    /// 鉴权信息, 包括appId, 密钥对
    /// </summary>
    public class Credentials
    {
        private readonly string appId;
        private readonly string secretId;
        private readonly string secretKey;

        public Credentials(string appId, string secretId, string secretKey)
        {
            if (appId == null || string.IsNullOrWhiteSpace(appId))
            {
                throw new Exception("AppId can not be null or empty");
            }
            if (secretId == null || string.IsNullOrWhiteSpace(secretId))
            {
                throw new Exception("secretId can not be null or empty");
            }
            if (secretKey == null || string.IsNullOrWhiteSpace(secretKey))
            {
                throw new Exception("secretKey can not be null or empty");
            }
            this.appId = appId;
            this.secretId = secretId;
            this.secretKey = secretKey;
        }

        public string getAppId()
        {
            return appId;
        }

        public string getSecretId()
        {
            return secretId;
        }

        public string getSecretKey()
        {
            return secretKey;
        }
    }
}
