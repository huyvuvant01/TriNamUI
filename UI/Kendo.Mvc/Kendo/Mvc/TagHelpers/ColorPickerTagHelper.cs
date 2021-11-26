// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ColorPickerTagHelper
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
  [HtmlTargetElement("kendo-colorpicker")]
  [HtmlTargetElement("colorpicker-editor", ParentTag = "form-item")]
  [RestrictChildren("tile-size", new string[] {"messages"})]
  [OutputElementHint("div")]
  public class ColorPickerTagHelper : TagHelperBase, IKendoFormEditor
  {
    public 
    #nullable disable
    string[] PaletteColors { get; set; }

    public string[] Views { get; set; }

    public string[] Formats { get; set; }

    public ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public ColorPickerTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ColorPickerTagHelper colorPickerTagHelper = this;
      context.Items[(object) colorPickerTagHelper.GetType()] = (object) colorPickerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (colorPickerTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await colorPickerTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer modelExplorer = (ModelExplorer) null;
      if (this.For != null)
      {
        this.Name = this.For.Name;
        modelExplorer = this.For.ModelExplorer;
        if (this.For.Model != null && (this.For.Model.GetType().IsPredefinedType() || this.For.Model.GetType().IsEnumType()))
          this.Value = Convert.ToString(this.For.Model);
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder colorInput = this.Generator.GenerateColorInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) this.Value, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.SelfClosing;
      output.MergeAttributes(colorInput);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "ColorPicker", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.PaletteColors != null && this.PaletteColors.Length > -1)
        dictionary["palette"] = (object) this.PaletteColors;
      if (this.Views != null && this.Views.Length > -1)
        dictionary["views"] = (object) this.Views;
      if (this.Formats != null && this.Formats.Length > -1)
        dictionary["formats"] = (object) this.Formats;
      return dictionary;
    }

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "ColorPicker";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnSelect { get; set; }

    public string OnOpen { get; set; }

    public string OnClose { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      return dictionary;
    }

    public bool? Buttons { get; set; }

    [HtmlAttributeNotBound]
    public ColorPickerContrastToolSettingsTagHelper ContrastTool { get; set; }

    public bool? CloseOnSelect { get; set; }

    public double? Columns { get; set; }

    public bool? Input { get; set; }

    [HtmlAttributeNotBound]
    public ColorPickerTileSizeSettingsTagHelper TileSize { get; set; }

    [HtmlAttributeNotBound]
    public ColorPickerMessagesSettingsTagHelper Messages { get; set; }

    public bool? Opacity { get; set; }

    public bool? Preview { get; set; }

    public string ToolIcon { get; set; }

    public string Value { get; set; }

    public ColorPickerPalette? Palette { get; set; }

    public ColorPickerFormat? Format { get; set; }

    public ColorPickerView? View { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Buttons.HasValue)
        dictionary1["buttons"] = (object) this.Buttons;
      if (this.ContrastTool != null)
      {
        Dictionary<string, object> source = this.ContrastTool.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.ContrastTool.Enabled.HasValue || this.ContrastTool.Enabled.Value))
          dictionary1["contrastTool"] = (object) source;
        else if (this.ContrastTool.Enabled.HasValue && this.ContrastTool.Enabled.Value)
          dictionary1["contrastTool"] = (object) this.ContrastTool.Enabled;
      }
      if (this.CloseOnSelect.HasValue)
        dictionary1["closeOnSelect"] = (object) this.CloseOnSelect;
      if (this.Columns.HasValue)
        dictionary1["columns"] = (object) this.Columns;
      if (this.Input.HasValue)
        dictionary1["input"] = (object) this.Input;
      if (this.TileSize != null)
      {
        Dictionary<string, object> source = this.TileSize.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tileSize"] = (object) source;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      if (this.Preview.HasValue)
        dictionary1["preview"] = (object) this.Preview;
      string toolIcon = this.ToolIcon;
      if ((toolIcon != null ? (toolIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["toolIcon"] = (object) this.ToolIcon;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
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
      if (this.View.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        ColorPickerView? view = this.View;
        ref ColorPickerView? local = ref view;
        string str4 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["view"] = (object) str4;
      }
      return dictionary1;
    }
  }
}
