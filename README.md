# tenyun-image-dotnet-v2.0
腾讯图像识别2.0API .net版

从 https://github.com/tencentyun/image-java-sdk-v2.0 移植为C#版

官方出了了v3.0 SDK，有C#的
但是有些老的API 3.0 SDK还不支持，比如 驾驶证识别。

花了半天时间，发现离改完还差的远，只能先转一个自己要用的API，后面的再说了
也许不久官方3.0就支持了

使用方法和官方一致，添加了一个应答类，可以将应答json转为应答对象

        ImageClient imageClient = new ImageClient(appId, secretId, secretKey, ImageClient.NEW_DOMAIN_recognition_image_myqcloud_com/*根据文档说明选择域名*/);

            String ret = null;
            // 1. 驾驶证 url方式
            Console.WriteLine("====================================================");
            OcrDrivingLicenceRequest request = new OcrDrivingLicenceRequest(bucketName, OcrDrivingLicenceRequest.TYPE_DRIVER_LICENSE, "上传到COS的图像地址");
            try
            {
                ret = imageClient.ocrDrivingLicence(request);
                OcrDrivingLicenceResponse r = JsonConvert.DeserializeObject<OcrDrivingLicenceResponse>(ret);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("ocrDrivingLicence:" + ret);



如果不想使用这套结构，想简单一点使用，只需要用里面生成sign的功能即可，其他调用自己写即可，如下

            string ret = "";

            using (WebClient client = new WebClient())
            {
                string sign = Sign.appSign(appid, secretId, secretKey);
                client.Headers.Add("Authorization", sign);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client.Headers.Add("Host", "recognition.image.myqcloud.com");

                var json = JsonConvert.SerializeObject(new
                {
                    appid = appid,
                    type = 1,
                    url = cosImageUrl
                });


                ret = client.UploadString(@"https://recognition.image.myqcloud.com/ocr/drivinglicence", json);
            }

            return JsonConvert.DeserializeObject<OcrDrivingLicenceResponse>(ret);
