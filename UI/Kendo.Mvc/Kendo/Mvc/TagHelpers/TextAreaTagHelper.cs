// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TextAreaTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-textarea")]
  [HtmlTargetElement("textarea-editor", ParentTag = "form-item")]
  [RestrictChildren("label", new string[] {})]
  public class TextAreaTagHelper : TagHelperBase, IKendoFormEditor
  {
    public TextAreaTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TextAreaTagHelper textAreaTagHelper = this;
      context.Items[(object) textAreaTagHelper.GetType()] = (object) textAreaTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (textAreaTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await textAreaTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("textarea", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "textarea";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "TextArea", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "TextArea";
          return true;
        }
      }
      return false;
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

    public double? Cols { get; set; }

    public bool? Enable { get; set; }

    [HtmlAttributeNotBound]
    public TextAreaLabelSettingsTagHelper Label { get; set; }

    public double? MaxLength { get; set; }

    public string Placeholder { get; set; }

    public bool? Readonly { get; set; }

    public string Resizable { get; set; }

    public double? Rows { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Cols.HasValue)
        dictionary["cols"] = (object) this.Cols;
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      if (this.Label != null)
      {
        Dictionary<string, object> source = this.Label.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["label"] = (object) source;
      }
      if (this.MaxLength.HasValue)
        dictionary["maxLength"] = (object) this.MaxLength;
      string placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["placeholder"] = (object) this.Placeholder;
      if (this.Readonly.HasValue)
        dictionary["readonly"] = (object) this.Readonly;
      string resizable = this.Resizable;
      if ((resizable != null ? (resizable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resizable"] = (object) this.Resizable;
      if (this.Rows.HasValue)
        dictionary["rows"] = (object) this.Rows;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
