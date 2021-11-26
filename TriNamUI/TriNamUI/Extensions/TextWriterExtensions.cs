using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.IO;
using System.Text.Encodings.Web;

namespace TriNamUI.Extensions
{
    /// <summary>
    /// TextWriterExtensions
    /// </summary>
    public static class TextWriterExtensions
    {
        /// <summary>
        /// WriteContent from TextWriter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="writer"></param>
        /// <param name="action"></param>
        /// <param name="htmlEncoder"></param>
        /// <param name="dataItem"></param>
        /// <param name="htmlEncode"></param>
        public static void WriteContent<T>(this TextWriter writer, Func<T, object> action, HtmlEncoder htmlEncoder, T dataItem = null, bool htmlEncode = false) where T : class
        {
            object obj = action(dataItem);
            if (obj is HelperResult helperResult)
            {
                helperResult.WriteTo(writer, htmlEncoder);
            }
            else if (obj != null)
            {
                if (htmlEncode)
                {
                    writer.Write(htmlEncoder.Encode(obj.ToString()));
                }
                else
                {
                    writer.Write(obj.ToString());
                }
            }
        }
    }
}
