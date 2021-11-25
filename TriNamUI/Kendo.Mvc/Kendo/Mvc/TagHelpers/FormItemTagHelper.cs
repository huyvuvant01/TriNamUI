// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FormItemTagHelper
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
  [HtmlTargetElement("form-item", ParentTag = "form-items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("item-label", new string[] {"form-items", "dropdownlist-editor", "autocomplete-editor", "combobox-editor", "multiselect-editor", "multicolumncombobox-editor", "dropdowntree-editor", "dateinput-editor", "datepicker-editor", "datetimepicker-editor", "timepicker-editor", "numerictextbox-editor", "maskedtextbox-editor", "switch-editor", "rating-editor", "slider-editor", "colorpicker-editor", "richtexteditor-editor", "radiogroup-editor", "checkboxgroup-editor", "textbox-editor", "textarea-editor", "captcha-editor"})]
  [SuppressTagRendering]
  public class FormItemTagHelper : TagHelperCollectionItemBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    FormItemsTagHelper Items { get; set; }

    internal Dictionary<string, object> EditorOptions { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (FormItemsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FormItemsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.EditorOptions != null)
        dictionary["editorOptions"] = (object) this.EditorOptions;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<FormItemTagHelper, Dictionary<string, object>>((Func<FormItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      return dictionary;
    }

    public string Type { get; set; }

    public string Field { get; set; }

    public string Editor { get; set; }

    public string EditorHandler { get; set; }

    [HtmlAttributeNotBound]
    public FormItemLabelSettingsTagHelper Label { get; set; }

    public string Id { get; set; }

    public string Title { get; set; }

    public string Hint { get; set; }

    public double? ColSpan { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      string editorHandler = this.EditorHandler;
      if ((editorHandler != null ? (editorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["editor"] = (object) this.CreateHandler(this.EditorHandler);
      }
      else
      {
        string editor = this.Editor;
        if ((editor != null ? (editor.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["editor"] = (object) this.Editor;
      }
      if (this.Label != null)
      {
        Dictionary<string, object> source = this.Label.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["label"] = (object) source;
      }
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string hint = this.Hint;
      if ((hint != null ? (hint.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hint"] = (object) this.Hint;
      if (this.ColSpan.HasValue)
        dictionary["colSpan"] = (object) this.ColSpan;
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      return dictionary;
    }
  }
}
