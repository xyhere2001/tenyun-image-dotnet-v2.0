using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    /// <summary>
    /// 封装HTTP请求头中的对应的K-V对中key枚举值类
    /// </summary>
    public class RequestHeaderKey
    {
        public static readonly String Authorization = "Authorization";
        public static readonly String Content_TYPE = "Content-Type";
        public static readonly String ACCEPT = "Accept";
        public static readonly String CONNECTION = "Connection";
        public static readonly String USER_AGENT = "User-Agent";
    }
}
