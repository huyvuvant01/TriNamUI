// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FlatColorPickerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-flatcolorpicker")]
  [RestrictChildren("contrast-tool", new string[] {"messages"})]
  public class FlatColorPickerTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    string[] PaletteColors { get; set; }

    public string[] Views { get; set; }

    public string[] Formats { get; set; }

    public ModelExpression For { get; set; }

    public FlatColorPickerTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      FlatColorPickerTagHelper colorPickerTagHelper = this;
      context.Items[(object) colorPickerTagHelper.GetType()] = (object) colorPickerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await colorPickerTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      if (this.For != null)
      {
        this.Name = this.For.Name;
        ModelExplorer modelExplorer = this.For.ModelExplorer;
        if (this.For.Model != null && (this.For.Model.GetType().IsPredefinedType() || this.For.Model.GetType().IsEnumType()))
          this.Value = Convert.ToString(this.For.Model);
      }
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.PaletteColors != null && this.PaletteColors.Length > -1)
        dictionary["palette"] = (object) this.PaletteColors;
      if (this.Views != null && this.Views.Length > -1)
        dictionary["views"] = (object) this.Views;
      if (this.Formats != null && this.Formats.Length > -1)
        dictionary["formats"] = (object) this.Formats;
      return this.Initializer.Initialize(this.Selector, "FlatColorPicker", (IDictionary<string, object>) dictionary);
    }

    public string OnChange { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      return dictionary;
    }

    public bool? Opacity { get; set; }

    public bool? Buttons { get; set; }

    public double? Columns { get; set; }

    [HtmlAttributeNotBound]
    public FlatColorPickerContrastToolSettingsTagHelper ContrastTool { get; set; }

    public bool? Input { get; set; }

    public string Value { get; set; }

    public bool? Preview { get; set; }

    public bool? Autoupdate { get; set; }

    [HtmlAttributeNotBound]
    public FlatColorPickerMessagesSettingsTagHelper Messages { get; set; }

    public ColorPickerPalette? Palette { get; set; }

    public ColorPickerFormat? Format { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      if (this.Buttons.HasValue)
        dictionary1["buttons"] = (object) this.Buttons;
      if (this.Columns.HasValue)
        dictionary1["columns"] = (object) this.Columns;
      if (this.ContrastTool != null)
      {
        Dictionary<string, object> source = this.ContrastTool.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.ContrastTool.Enabled.HasValue || this.ContrastTool.Enabled.Value))
          dictionary1["contrastTool"] = (object) source;
        else if (this.ContrastTool.Enabled.HasValue && this.ContrastTool.Enabled.Value)
          dictionary1["contrastTool"] = (object) this.ContrastTool.Enabled;
      }
      if (this.Input.HasValue)
        dictionary1["input"] = (object) this.Input;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.Preview.HasValue)
        dictionary1["preview"] = (object) this.Preview;
      if (this.Autoupdate.HasValue)
        dictionary1["autoupdate"] = (object) this.Autoupdate;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.Palette.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ColorPickerPalette? palette = this.Palette;
        ref ColorPickerPalette? local = ref palette;
        string str2 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["palette"] = (object) str2;
      }
      if (this.Format.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        ColorPickerFormat? format = this.Format;
        ref ColorPickerFormat? local = ref format;
        string str3 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["format"] = (object) str3;
      }
      return dictionary1;
    }
  }
}
