// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartAxisDefaultsMajorGridLinesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("major-grid-lines", ParentTag = "axis-defaults", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartAxisDefaultsMajorGridLinesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartAxisDefaultsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartAxisDefaultsSettingsTagHelper).MajorGridLines = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public Kendo.Mvc.UI.DashType? DashType { get; set; }

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public double? Step { get; set; }

    public double? Skip { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      Kendo.Mvc.UI.DashType? dashType = this.DashType;
      if (dashType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        dashType = this.DashType;
        ref Kendo.Mvc.UI.DashType? local = ref dashType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["dashType"] = (object) str;
      }
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      double? nullable = this.Width;
      if (nullable.HasValue)
        dictionary1["width"] = (object) this.Width;
      nullable = this.Step;
      if (nullable.HasValue)
        dictionary1["step"] = (object) this.Step;
      nullable = this.Skip;
      if (nullable.HasValue)
        dictionary1["skip"] = (object) this.Skip;
      return dictionary1;
    }
  }
}
