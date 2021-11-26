// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.TextWriterExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.Extensions
{
  public static class TextWriterExtensions
  {
    public static void WriteContent<T>(
      this TextWriter writer,
      Func<T, object> action,
      HtmlEncoder htmlEncoder,
      T dataItem = null,
      bool htmlEncode = false)
      where T : class
    {
      object obj = action(dataItem);
      if (obj is HelperResult helperResult)
      {
        helperResult.WriteTo(writer, htmlEncoder);
      }
      else
      {
        if (obj == null)
          return;
        if (htmlEncode)
          writer.Write(htmlEncoder.Encode(obj.ToString()));
        else
          writer.Write(obj.ToString());
      }
    }
  }
}
