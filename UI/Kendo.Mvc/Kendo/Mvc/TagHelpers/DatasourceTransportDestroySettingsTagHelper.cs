// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DatasourceTransportDestroySettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("destroy", ParentTag = "transport", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DatasourceTransportDestroySettingsTagHelper : TagHelperChildBase
  {
    public bool? Cache { get; set; }

    public 
    #nullable disable
    string ContentType { get; set; }

    public string Datatype { get; set; }

    public string Type { get; set; }

    public string Url { get; set; }

    public string Data { get; set; }

    public IDictionary<string, string> Headers { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (DataSourceTransportSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceTransportSettingsTagHelper).Destroy = this;
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Cache.HasValue)
        dictionary["cache"] = (object) this.Cache;
      string contentType = this.ContentType;
      if ((contentType != null ? (contentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentType"] = (object) this.ContentType;
      string datatype = this.Datatype;
      if ((datatype != null ? (datatype.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataType"] = (object) this.Datatype;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["url"] = (object) this.Url;
      string data = this.Data;
      if ((data != null ? (data.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["data"] = (object) this.CreateHandler(this.Data);
      IDictionary<string, string> headers = this.Headers;
      if ((headers != null ? (headers.Any<KeyValuePair<string, string>>() ? 1 : 0) : 0) != 0)
        dictionary["headers"] = (object) this.Headers;
      return dictionary;
    }
  }
}
