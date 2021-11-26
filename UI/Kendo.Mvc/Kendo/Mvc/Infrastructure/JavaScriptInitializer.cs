// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.JavaScriptInitializer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
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

namespace Kendo.Mvc.Infrastructure
{
  public class JavaScriptInitializer : IJavaScriptInitializer
  {
    private static readonly Regex EscapeRegex = new Regex("([;&,\\.\\+\\*~'\\:\\\"\\!\\^\\$\\[\\]\\(\\)\\|\\/])", RegexOptions.Compiled);

    public virtual string Initialize(string id, string name, IDictionary<string, object> options) => this.InitializeFor(JavaScriptInitializer.EscapeRegex.Replace(id, "\\\\$1"), name, options);

    public virtual string InitializeFor(
      string selector,
      string name,
      IDictionary<string, object> options)
    {
      return new StringBuilder().Append("kendo.syncReady(function(){jQuery(\"").Append(selector).Append("\").kendo").Append(name).Append("(").Append(this.Serialize(options)).Append(");});").ToString();
    }

    public virtual IJavaScriptSerializer CreateSerializer() => (IJavaScriptSerializer) new DefaultJavaScriptSerializer();

    public virtual string Serialize(IDictionary<string, object> @object)
    {
      StringBuilder output = new StringBuilder();
      output.Append("{");
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) @object)
      {
        object obj = keyValuePair.Value;
        if (obj is string str2)
        {
          if (keyValuePair.Key == "dataSourceId")
          {
            output.Append(",\"dataSource\":");
            output.Append(str2.JavaScriptStringEncode(false));
            continue;
          }
          if (keyValuePair.Key == "dependenciesId")
          {
            output.Append(",\"dependencies\":");
            output.Append(str2.JavaScriptStringEncode(false));
            continue;
          }
        }
        output.Append(",").Append("\"" + keyValuePair.Key + "\"").Append(":");
        if (str2 != null)
        {
          if (keyValuePair.Key == "url")
            output.Append("\"" + str2 + "\"");
          else
            output.Append(str2.JavaScriptStringEncode(true));
        }
        else
        {
          switch (obj)
          {
            case IDictionary<string, object> object4:
              output.Append(this.Serialize(object4));
              continue;
            case IEnumerable<DateTime> dates3:
              this.AppendDates(output, dates3);
              continue;
            case IEnumerable<IDictionary<string, object>> array3:
              this.AppendArrayOfObjects(output, array3);
              continue;
            default:
              IJavaScriptSerializer serializer = this.CreateSerializer();
              switch (obj)
              {
                case IEnumerable enumerable4:
                  output.Append(serializer.Serialize((object) enumerable4));
                  continue;
                case bool flag4:
                  this.AppendBoolean(output, flag4);
                  continue;
                case DateTime dateTime4:
                  this.AppendDate(output, dateTime4);
                  continue;
                case int num13:
                  output.Append(num13);
                  continue;
                case double num14:
                  output.Append(num14.ToString("r", (IFormatProvider) CultureInfo.InvariantCulture));
                  continue;
                case float num15:
                  output.Append(num15.ToString("r", (IFormatProvider) CultureInfo.InvariantCulture));
                  continue;
                case Guid _:
                  output.AppendFormat("\"{0}\"", (object) obj.ToString());
                  continue;
                case null:
                  output.Append("null");
                  continue;
                default:
                  if (!obj.GetType().GetTypeInfo().IsPrimitive)
                  {
                    switch (obj)
                    {
                      case Decimal _:
                        break;
                      case ClientHandlerDescriptor handlerDescriptor6:
                        this.AppendEvent(output, handlerDescriptor6);
                        continue;
                      case Enum _:
                        output.Append(obj.ToString().ToLower().JavaScriptStringEncode(true));
                        continue;
                      default:
                        output.Append(serializer.Serialize(obj));
                        continue;
                    }
                  }
                  this.AppendConvertible(output, obj);
                  continue;
              }
          }
        }
      }
      if (output.Length >= 2)
        output.Remove(1, 1);
      output.Append("}");
      return output.ToString();
    }

    private void AppendBoolean(StringBuilder output, bool value)
    {
      if (value)
        output.Append("true");
      else
        output.Append("false");
    }

    private void AppendEvent(StringBuilder output, ClientHandlerDescriptor value)
    {
      if (value.HandlerName.HasValue())
      {
        output.Append(value.HandlerName);
      }
      else
      {
        if (value.TemplateDelegate == null)
          return;
        using (StringWriter writer = new StringWriter())
        {
          writer.WriteContent<object>(value.TemplateDelegate, HtmlEncoder.Default, (object) value);
          output.Append(writer.ToString());
        }
      }
    }

    private void AppendDates(StringBuilder output, IEnumerable<DateTime> dates)
    {
      output.Append("[");
      if (dates.Any<DateTime>())
      {
        foreach (DateTime date in dates)
        {
          this.AppendDate(output, date);
          output.Append(",");
        }
        output.Remove(output.Length - 1, 1);
      }
      output.Append("]");
    }

    private void AppendArrayOfObjects(
      StringBuilder output,
      IEnumerable<IDictionary<string, object>> array)
    {
      output.Append("[");
      if (array.Any<IDictionary<string, object>>())
      {
        foreach (IDictionary<string, object> @object in array)
        {
          output.Append(this.Serialize(@object));
          output.Append(",");
        }
        output.Remove(output.Length - 1, 1);
      }
      output.Append("]");
    }

    private void AppendDate(StringBuilder output, DateTime value) => output.Append("new Date(").Append(value.Year).Append(",").Append(value.Month - 1).Append(",").Append(value.Day).Append(",").Append(value.Hour).Append(",").Append(value.Minute).Append(",").Append(value.Second).Append(",").Append(value.Millisecond).Append(")");

    private void AppendConvertible(StringBuilder output, object value) => output.Append(Convert.ToString(value, (IFormatProvider) CultureInfo.InvariantCulture));
  }
}
