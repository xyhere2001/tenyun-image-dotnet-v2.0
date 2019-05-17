using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    public abstract class AbstractBaseRequest
    {
        // bucket名
        //private String bucketName;

        private BytesContent mBytesContent;

        public AbstractBaseRequest(String bucketName)
        {
            //super();
            BucketName = bucketName;
        }

        // 获取bucket名
        public String BucketName
        {
            get; set;
        }

        // 设置bucket名
        //public void setBucketName(String bucketName)
        //{
        //    this.bucketName = bucketName;
        //}

        protected String getMemberStringValue(String member)
        {
            if (member != null)
            {
                return member;
            }
            else
            {
                return "null";
            }
        }

        // 将request转换为字符串, 用于记录信息
        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("bucketName:").Append(getMemberStringValue(BucketName));
            return sb.ToString();
        }

        // 检查用户的输入参数
        public virtual void check_param()
        {
            //CommonParamCheckUtils.AssertNotNull("bucketName", this.bucketName);
        }

        void setBytesContent(String key, byte[] content)
        {
            mBytesContent = new BytesContent(key, content);
        }

        public BytesContent getBytesContent()
        {
            return mBytesContent;
        }

        public  class BytesContent
        {

            //String key;
            //byte[] content;

            public BytesContent(String key, byte[] content)
            {
                Key = key;
                Content = content;
            }

            public  String Key
            {
                get; set;
            }

            public  byte[] Content
            {
                get; set;
            }

        }
    }
}
