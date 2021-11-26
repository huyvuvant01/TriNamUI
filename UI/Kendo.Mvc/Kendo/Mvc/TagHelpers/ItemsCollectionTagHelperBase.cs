// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ItemsCollectionTagHelperBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers
{
  public class ItemsCollectionTagHelperBase : 
    TagHelperBase,
    IDataBoundWidget<HierarchicalDataSourceTagHelper>
  {
    [HtmlAttributeName("datasource-id")]
    public string DataSourceId { get; set; }

    [HtmlAttributeNotBound]
    public HierarchicalDataSourceTagHelper Datasource { get; set; }

    [HtmlAttributeNotBound]
    public ItemsAnimationSettingsTagHelper Animation { get; set; }

    public ItemsCollectionTagHelperBase(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Items", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = this.SerializeEvents();
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary["animation"] = (object) this.Animation.Enabled;
      }
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      return dictionary;
    }

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    protected override void WriteHtml(TagHelperOutput output)
    {
    }
  }
}
