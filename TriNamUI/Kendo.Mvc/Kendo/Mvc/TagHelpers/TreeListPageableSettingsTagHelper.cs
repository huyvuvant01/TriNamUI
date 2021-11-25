// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListPageableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pageable", ParentTag = "kendo-treelist", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("messages", new string[] {})]
  [SuppressTagRendering]
  public class TreeListPageableSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    int[] PageSizes { get; set; }

    public bool? PageSizesEnabled { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListTagHelper).Pageable = this;
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

    public bool? Enabled { get; set; }

    public bool? AlwaysVisible { get; set; }

    public double? PageSize { get; set; }

    public bool? PreviousNext { get; set; }

    public bool? Numeric { get; set; }

    public double? ButtonCount { get; set; }

    public bool? Input { get; set; }

    public bool? Refresh { get; set; }

    public bool? Responsive { get; set; }

    public bool? Info { get; set; }

    [HtmlAttributeNotBound]
    public TreeListPageableMessagesSettingsTagHelper Messages { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AlwaysVisible.HasValue)
        dictionary["alwaysVisible"] = (object) this.AlwaysVisible;
      if (this.PageSize.HasValue)
        dictionary["pageSize"] = (object) this.PageSize;
      if (this.PreviousNext.HasValue)
        dictionary["previousNext"] = (object) this.PreviousNext;
      if (this.Numeric.HasValue)
        dictionary["numeric"] = (object) this.Numeric;
      if (this.ButtonCount.HasValue)
        dictionary["buttonCount"] = (object) this.ButtonCount;
      if (this.Input.HasValue)
        dictionary["input"] = (object) this.Input;
      if (this.Refresh.HasValue)
        dictionary["refresh"] = (object) this.Refresh;
      if (this.Responsive.HasValue)
        dictionary["responsive"] = (object) this.Responsive;
      if (this.Info.HasValue)
        dictionary["info"] = (object) this.Info;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }
  }
}
