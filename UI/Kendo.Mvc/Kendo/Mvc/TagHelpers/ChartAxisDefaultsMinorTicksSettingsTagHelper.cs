// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartAxisDefaultsMinorTicksSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("minor-ticks", ParentTag = "axis-defaults", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartAxisDefaultsMinorTicksSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartAxisDefaultsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartAxisDefaultsSettingsTagHelper).MinorTicks = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public double? Size { get; set; }

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public double? Step { get; set; }

    public double? Skip { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      double? nullable = this.Size;
      if (nullable.HasValue)
        dictionary["size"] = (object) this.Size;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary["width"] = (object) this.Width;
      nullable = this.Step;
      if (nullable.HasValue)
        dictionary["step"] = (object) this.Step;
      nullable = this.Skip;
      if (nullable.HasValue)
        dictionary["skip"] = (object) this.Skip;
      return dictionary;
    }
  }
}
