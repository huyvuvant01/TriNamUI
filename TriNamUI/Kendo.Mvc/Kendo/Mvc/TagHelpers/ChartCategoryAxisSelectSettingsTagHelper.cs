// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartCategoryAxisSelectSettingsTagHelper
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
  [HtmlTargetElement("select", ParentTag = "category-axis-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("mousewheel", new string[] {})]
  [SuppressTagRendering]
  public class ChartCategoryAxisSelectSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartCategoryAxisTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartCategoryAxisTagHelper).Select = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public object From { get; set; }

    public object Max { get; set; }

    public object Min { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisSelectMousewheelSettingsTagHelper Mousewheel { get; set; }

    public object To { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.From != null)
        dictionary["from"] = this.From;
      if (this.Max != null)
        dictionary["max"] = this.Max;
      if (this.Min != null)
        dictionary["min"] = this.Min;
      if (this.Mousewheel != null)
      {
        Dictionary<string, object> source = this.Mousewheel.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["mousewheel"] = (object) source;
      }
      if (this.To != null)
        dictionary["to"] = this.To;
      return dictionary;
    }
  }
}
