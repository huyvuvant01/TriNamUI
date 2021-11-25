// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartAxisDefaultsLabelsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("labels", ParentTag = "axis-defaults", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("chart-axis-defaults-labels-margin", new string[] {"chart-axis-defaults-labels-padding", "chart-axis-defaults-labels-rotation"})]
  [SuppressTagRendering]
  public class ChartAxisDefaultsLabelsSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Visual { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartAxisDefaultsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartAxisDefaultsSettingsTagHelper).Labels = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }

    public string Font { get; set; }

    public string Format { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsLabelsMarginSettingsTagHelper Margin { get; set; }

    public bool? Mirror { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsLabelsPaddingSettingsTagHelper Padding { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsLabelsRotationSettingsTagHelper Rotation { get; set; }

    public double? Skip { get; set; }

    public double? Step { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["margin"] = (object) source;
      }
      bool? nullable1 = this.Mirror;
      if (nullable1.HasValue)
        dictionary["mirror"] = (object) this.Mirror;
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["padding"] = (object) source;
      }
      if (this.Rotation != null)
      {
        Dictionary<string, object> source = this.Rotation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["rotation"] = (object) source;
      }
      double? nullable2 = this.Skip;
      if (nullable2.HasValue)
        dictionary["skip"] = (object) this.Skip;
      nullable2 = this.Step;
      if (nullable2.HasValue)
        dictionary["step"] = (object) this.Step;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable1 = this.Visible;
      if (nullable1.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
