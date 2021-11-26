// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MaskedTextBoxTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
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
  [HtmlTargetElement("kendo-maskedtextbox", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("maskedtextbox-editor", ParentTag = "form-item")]
  [RestrictChildren("maskedtextbox-label", new string[] {})]
  public class MaskedTextBoxTagHelper : TagHelperBase, IKendoFormEditor
  {
    public 
    #nullable disable
    IDictionary<string, string> Rules { get; set; }

    public ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public MaskedTextBoxTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
      this.Rules = (IDictionary<string, string>) new Dictionary<string, string>();
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      MaskedTextBoxTagHelper textBoxTagHelper = this;
      context.Items[(object) textBoxTagHelper.GetType()] = (object) textBoxTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (textBoxTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await textBoxTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer modelExplorer = (ModelExplorer) null;
      if (this.For != null)
      {
        modelExplorer = this.For.ModelExplorer;
        this.Name = this.For.Name;
        if (this.For.Model != null && (this.For.Model.GetType().IsPredefinedType() || this.For.Model.GetType().IsEnumType()))
          this.Value = Convert.ToString(this.For.Model);
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder input = this.Generator.GenerateInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) this.Value, string.Empty, string.Empty, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.StartTagAndEndTag;
      output.MergeAttributes(input);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "MaskedTextBox", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      dictionary["rules"] = (object) this.ToDictionaryHandler(this.Rules);
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
          formItemTagHelper1.Editor = "MaskedTextBox";
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

    public bool? ClearPromptChar { get; set; }

    public string Culture { get; set; }

    [HtmlAttributeNotBound]
    public MaskedTextBoxLabelSettingsTagHelper Label { get; set; }

    public string Mask { get; set; }

    public string PromptChar { get; set; }

    public bool? UnmaskOnPost { get; set; }

    public string Value { get; set; }

    public bool? Enable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ClearPromptChar.HasValue)
        dictionary["clearPromptChar"] = (object) this.ClearPromptChar;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["culture"] = (object) this.Culture;
      if (this.Label != null)
      {
        Dictionary<string, object> source = this.Label.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["label"] = (object) source;
      }
      string mask = this.Mask;
      if ((mask != null ? (mask.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mask"] = (object) this.Mask;
      string promptChar = this.PromptChar;
      if ((promptChar != null ? (promptChar.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["promptChar"] = (object) this.PromptChar;
      if (this.UnmaskOnPost.HasValue)
        dictionary["unmaskOnPost"] = (object) this.UnmaskOnPost;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      return dictionary;
    }
  }
}
