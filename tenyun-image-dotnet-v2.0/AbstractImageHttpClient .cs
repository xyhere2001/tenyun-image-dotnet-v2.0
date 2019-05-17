using System;
using System.Collections.Generic;
using System.Text;

namespace qcloud.image
{
    public abstract class AbstractImageHttpClient
    {
        ClientConfig config;

        AbstractImageHttpClient(ClientConfig config)
        {
            //super();
            this.config = config;
        }


        protected abstract String sendPostRequest(HttpRequest httpRequest);


        public String sendHttpRequest(HttpRequest httpRequest)
        {

            HttpMethod method = httpRequest.getMethod();
            if (method == HttpMethod.POST)
            {
                return sendPostRequest(httpRequest);
            }
            else
            {
                throw new Exception("Unsupported Http Method");
            }
        }

        public abstract void shutdown();
    }
}
