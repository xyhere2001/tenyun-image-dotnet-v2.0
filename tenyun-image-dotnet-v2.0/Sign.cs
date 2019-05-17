using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace qcloud.image
{
    public class Sign
    {

        /**
 * 返回图片识别的签名
 * 
 * @param cred
 *            包含用户秘钥信息
 * @param bucketName
 *            bucket名
 * @param expired
 *            超时时间
 * @return 返回base64编码的字符串
 * @throws AbstractImageException  异常
 */
        public static String appSign(Credentials cred, String bucketName, long expired)
        {
            String appId = cred.getAppId();
            String secretId = cred.getSecretId();
            String secretKey = cred.getSecretKey();

            return appSign(appId, secretId, secretKey, expired);
        }


        public static string appSign(string appId, string secretId, string secretKey, long expired = 300, string bucketName = "")
        {
            long now = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;//System.currentTimeMillis() / 1000;
            int rdm = new Random().Next();
            string plainText = String.Format("a={0}&b={1}&k={2}&t={3}&e={4}&r={5}", appId, bucketName,
                    secretId, now, now + expired, rdm);
            byte[] hmacDigest = HmacSha1(plainText, secretKey);
            byte[] originalBytes = System.Text.Encoding.Default.GetBytes(plainText);
            byte[] signContent = new byte[hmacDigest.Length + originalBytes.Length];
            System.Buffer.BlockCopy(hmacDigest, 0, signContent, 0, hmacDigest.Length);
            System.Buffer.BlockCopy(originalBytes, 0, signContent, hmacDigest.Length, originalBytes.Length);
            return Base64Encode(signContent);
        }

        /**
         * 生成 base64 编码
         * 
         * @param binaryData
         * @return
         */
        public static string Base64Encode(byte[] binaryData)
        {
            var bs = Convert.ToBase64String(binaryData);
            string encodedstr = bs;// Base64.getEncoder().encodeToString(binaryData);
            return encodedstr;
        }

        /**
         * 生成 hmacsha1 签名
         * 
         * @param binaryData
         * @param key
         * @return
         * @throws Exception
         */
        public static byte[] HmacSha1(byte[] binaryData, string key)
        {
            //Mac mac = Mac.getInstance("HmacSHA1");
            //SecretKeySpec secretKey = new SecretKeySpec(key.getBytes(), "HmacSHA1");
            //mac.init(secretKey);
            //byte[] HmacSha1Digest = mac.doFinal(binaryData);
            //return HmacSha1Digest;

            byte[] hashValue = null;

            using (HMACSHA1 hmac = new HMACSHA1(System.Text.Encoding.Default.GetBytes(key)))
            {
                // Compute the hash of the input file.
                hashValue = hmac.ComputeHash(binaryData);
            }

            return hashValue;
        }

        /**
         * 生成 hmacsha1 签名
         * 
         * @param plainText
         * @param key
         * @return
         * @throws Exception
         */
        public static byte[] HmacSha1(string plainText, string key)
        {
            var bs = System.Text.Encoding.Default.GetBytes(plainText);
            return HmacSha1(bs, key);
        }
    }
}
