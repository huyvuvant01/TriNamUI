using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using TriNamUI.Extensions;

namespace TriNamUI.Infrastructure
{
    public partial class JavaScriptInitializer : IJavaScriptInitializer
    {
        #region Fields

        private static readonly Regex EscapeRegex = new Regex("([;&,\\.\\+\\*~'\\:\\\"\\!\\^\\$\\[\\]\\(\\)\\|\\/])", RegexOptions.Compiled);

        #endregion


        public virtual string Initialize(string id, string name, IDictionary<string, object> options)
        {
            return InitializeFor(EscapeRegex.Replace(id, "\\\\$1"), name, options);
        }

        public virtual string InitializeFor(string selector, string name, IDictionary<string, object> options)
        {
            return new StringBuilder().Append("TriNam.syncReady(function(){jQuery(\"").Append(selector).Append("\").kendo")
                .Append(name)
                .Append("(")
                .Append(Serialize(options))
                .Append(");});")
                .ToString();
        }

        public virtual IJavaScriptSerializer CreateSerializer()
        {
            return new DefaultJavaScriptSerializer();
        }

        public virtual string Serialize(IDictionary<string, object> @object)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            foreach (KeyValuePair<string, object> item in @object)
            {
                object value = item.Value;
                string text = value as string;
                if (text != null)
                {
                    if (item.Key == "dataSourceId")
                    {
                        stringBuilder.Append(",\"dataSource\":");
                        stringBuilder.Append(text.JavaScriptStringEncode(addDoubleQuotes: false));
                        continue;
                    }
                    if (item.Key == "dependenciesId")
                    {
                        stringBuilder.Append(",\"dependencies\":");
                        stringBuilder.Append(text.JavaScriptStringEncode(addDoubleQuotes: false));
                        continue;
                    }
                }
                stringBuilder.Append(",").Append("\"" + item.Key + "\"").Append(":");
                if (text != null)
                {
                    if (item.Key == "url")
                    {
                        stringBuilder.Append("\"" + text + "\"");
                    }
                    else
                    {
                        stringBuilder.Append(text.JavaScriptStringEncode(addDoubleQuotes: true));
                    }
                    continue;
                }
                IDictionary<string, object> dictionary = value as IDictionary<string, object>;
                if (dictionary != null)
                {
                    stringBuilder.Append(Serialize(dictionary));
                    continue;
                }
                IEnumerable<DateTime> enumerable = value as IEnumerable<DateTime>;
                if (enumerable != null)
                {
                    AppendDates(stringBuilder, enumerable);
                    continue;
                }
                IEnumerable<IDictionary<string, object>> enumerable2 = value as IEnumerable<IDictionary<string, object>>;
                if (enumerable2 != null)
                {
                    AppendArrayOfObjects(stringBuilder, enumerable2);
                    continue;
                }
                IJavaScriptSerializer javaScriptSerializer = CreateSerializer();
                IEnumerable enumerable3 = value as IEnumerable;
                if (enumerable3 != null)
                {
                    stringBuilder.Append(javaScriptSerializer.Serialize(enumerable3));
                    continue;
                }
                if (value is bool)
                {
                    AppendBoolean(stringBuilder, (bool)value);
                    continue;
                }
                if (value is DateTime)
                {
                    AppendDate(stringBuilder, (DateTime)value);
                    continue;
                }
                if (value is int)
                {
                    stringBuilder.Append((int)value);
                    continue;
                }
                if (value is double)
                {
                    stringBuilder.Append(((double)value).ToString("r", CultureInfo.InvariantCulture));
                    continue;
                }
                if (value is float)
                {
                    stringBuilder.Append(((float)value).ToString("r", CultureInfo.InvariantCulture));
                    continue;
                }
                if (value is Guid)
                {
                    stringBuilder.AppendFormat("\"{0}\"", value.ToString());
                    continue;
                }
                if (value == null)
                {
                    stringBuilder.Append("null");
                    continue;
                }
                if (value.GetType().GetTypeInfo().IsPrimitive || value is decimal)
                {
                    AppendConvertible(stringBuilder, value);
                    continue;
                }
                ClientHandlerDescriptor clientHandlerDescriptor = value as ClientHandlerDescriptor;
                if (clientHandlerDescriptor != null)
                {
                    AppendEvent(stringBuilder, clientHandlerDescriptor);
                }
                else if (value is Enum)
                {
                    stringBuilder.Append(value.ToString()!.ToLower().JavaScriptStringEncode(addDoubleQuotes: true));
                }
                else
                {
                    stringBuilder.Append(javaScriptSerializer.Serialize(value));
                }
            }
            if (stringBuilder.Length >= 2)
            {
                stringBuilder.Remove(1, 1);
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        private void AppendBoolean(StringBuilder output, bool value)
        {
            if (value)
            {
                output.Append("true");
            }
            else
            {
                output.Append("false");
            }
        }

        private void AppendEvent(StringBuilder output, ClientHandlerDescriptor value)
        {
            if (value.HandlerName.HasValue())
            {
                output.Append(value.HandlerName);
            }
            else if (value.TemplateDelegate != null)
            {
                using StringWriter stringWriter = new StringWriter();
                stringWriter.WriteContent(value.TemplateDelegate, HtmlEncoder.Default, value);
                output.Append(stringWriter.ToString());
            }
        }

        private void AppendDates(StringBuilder output, IEnumerable<DateTime> dates)
        {
            output.Append("[");
            if (dates.Any())
            {
                foreach (DateTime date in dates)
                {
                    AppendDate(output, date);
                    output.Append(",");
                }
                output.Remove(output.Length - 1, 1);
            }
            output.Append("]");
        }

        private void AppendArrayOfObjects(StringBuilder output, IEnumerable<IDictionary<string, object>> array)
        {
            output.Append("[");
            if (array.Any())
            {
                foreach (IDictionary<string, object> item in array)
                {
                    output.Append(Serialize(item));
                    output.Append(",");
                }
                output.Remove(output.Length - 1, 1);
            }
            output.Append("]");
        }

        private void AppendDate(StringBuilder output, DateTime value)
        {
            output.Append("new Date(").Append(value.Year).Append(",")
                .Append(value.Month - 1)
                .Append(",")
                .Append(value.Day)
                .Append(",")
                .Append(value.Hour)
                .Append(",")
                .Append(value.Minute)
                .Append(",")
                .Append(value.Second)
                .Append(",")
                .Append(value.Millisecond)
                .Append(")");
        }

        private void AppendConvertible(StringBuilder output, object value)
        {
            output.Append(Convert.ToString(value, CultureInfo.InvariantCulture));
        }
    }
}
