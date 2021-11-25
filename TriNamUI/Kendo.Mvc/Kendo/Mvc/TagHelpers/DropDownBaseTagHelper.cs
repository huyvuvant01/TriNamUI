// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownBaseTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers
{
  public class DropDownBaseTagHelper : TagHelperBase, IDataBoundWidget<DataSourceTagHelper>
  {
    public DropDownBaseTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeNotBound]
    public DropDownPopupAnimationSettingsTagHelper Animation { get; set; }

    [HtmlAttributeNotBound]
    public DropDownPopupSettingsTagHelper Popup { get; set; }

    [HtmlAttributeNotBound]
    public DropDownVirtualSettingsTaghelper Virtual { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceTagHelper Datasource { get; set; }

    public string DatasourceId { get; set; }

    protected override void WriteHtml(TagHelperOutput output)
    {
    }

    public IEnumerable<object> BindTo { get; set; }

    internal IEnumerable Data { get; set; }

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

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
      if (this.Popup != null)
      {
        Dictionary<string, object> source = this.Popup.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["popup"] = (object) source;
      }
      if (this.Virtual != null)
      {
        Dictionary<string, object> source = this.Virtual.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Virtual.Enabled.HasValue || this.Virtual.Enabled.Value))
          dictionary["virtual"] = (object) source;
        else if (this.Virtual.Enabled.HasValue && this.Virtual.Enabled.Value)
          dictionary["virtual"] = (object) this.Virtual.Enabled;
      }
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      else if (this.BindTo != null)
        dictionary["dataSource"] = (object) this.BindTo;
      return dictionary;
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "DropDown", (IDictionary<string, object>) this.SerializeSettings());
  }
}
