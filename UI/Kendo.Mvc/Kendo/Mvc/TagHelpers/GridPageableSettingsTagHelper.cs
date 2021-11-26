// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridPageableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pageable", ParentTag = "kendo-grid", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("messages", new string[] {})]
  [SuppressTagRendering]
  public class GridPageableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Pageable = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      int[] pageSizes = this.PageSizes;
      if ((pageSizes != null ? (((IEnumerable<int>) pageSizes).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["pageSizes"] = (object) this.PageSizes;
      else if (this.PageSizesEnabled.HasValue)
        dictionary["pageSizes"] = (object) this.PageSizesEnabled;
      return dictionary;
    }

    public int[] PageSizes { get; set; }

    public bool? PageSizesEnabled { get; set; }

    public bool? Enabled { get; set; }

    public bool? AlwaysVisible { get; set; }

    public double? ButtonCount { get; set; }

    public bool? Info { get; set; }

    public bool? Input { get; set; }

    [HtmlAttributeNotBound]
    public GridPageableMessagesSettingsTagHelper Messages { get; set; }

    public bool? Numeric { get; set; }

    public double? PageSize { get; set; }

    public GridPagerPosition? Position { get; set; }

    public bool? PreviousNext { get; set; }

    public bool? Refresh { get; set; }

    public bool? Responsive { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.AlwaysVisible.HasValue)
        dictionary1["alwaysVisible"] = (object) this.AlwaysVisible;
      if (this.ButtonCount.HasValue)
        dictionary1["buttonCount"] = (object) this.ButtonCount;
      if (this.Info.HasValue)
        dictionary1["info"] = (object) this.Info;
      if (this.Input.HasValue)
        dictionary1["input"] = (object) this.Input;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.Numeric.HasValue)
        dictionary1["numeric"] = (object) this.Numeric;
      if (this.PageSize.HasValue)
        dictionary1["pageSize"] = (object) this.PageSize;
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        GridPagerPosition? position = this.Position;
        ref GridPagerPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      if (this.PreviousNext.HasValue)
        dictionary1["previousNext"] = (object) this.PreviousNext;
      if (this.Refresh.HasValue)
        dictionary1["refresh"] = (object) this.Refresh;
      if (this.Responsive.HasValue)
        dictionary1["responsive"] = (object) this.Responsive;
      return dictionary1;
    }
  }
}
