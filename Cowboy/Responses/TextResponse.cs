﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cowboy.Responses
{
    public class TextResponse : Response
    {
        public TextResponse(string contents, string contentType = "text/plain", Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            this.ContentType = contentType;
            this.StatusCode = HttpStatusCode.OK;

            if (contents != null)
            {
                this.Contents = stream =>
                {
                    var data = encoding.GetBytes(contents);
                    stream.Write(data, 0, data.Length);
                };
            }
        }

        //public TextResponse(HttpStatusCode statusCode = HttpStatusCode.OK, string contents = null, Encoding encoding = null, IDictionary<string, string> headers = null, IEnumerable<INancyCookie> cookies = null)
        //{
        //    if (encoding == null)
        //    {
        //        encoding = Encoding.UTF8;
        //    }

        //    this.ContentType = "text/plain";
        //    this.StatusCode = statusCode;

        //    if (contents != null)
        //    {
        //        this.Contents = stream =>
        //        {
        //            var data = encoding.GetBytes(contents);
        //            stream.Write(data, 0, data.Length);
        //        };
        //    }

        //    if (headers != null)
        //    {
        //        this.Headers = headers;
        //    }

        //    //if (cookies != null)
        //    //{
        //    //    foreach (var nancyCookie in cookies)
        //    //    {
        //    //        this.Cookies.Add(nancyCookie);
        //    //    }
        //    //}
        //}
    }
}
