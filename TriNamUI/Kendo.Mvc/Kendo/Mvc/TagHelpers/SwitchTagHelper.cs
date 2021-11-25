// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SwitchTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
  [HtmlTargetElement("kendo-switch")]
  [HtmlTargetElement("switch-editor", ParentTag = "form-item")]
  [RestrictChildren("messages", new string[] {})]
  public class SwitchTagHelper : TagHelperBase, IKendoFormEditor
  {
    public 
    #nullable disable
    ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public SwitchTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      SwitchTagHelper switchTagHelper = this;
      context.Items[(object) switchTagHelper.GetType()] = (object) switchTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (switchTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await switchTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer modelExplorer = (ModelExplorer) null;
      if (this.For != null)
      {
        modelExplorer = this.For.ModelExplorer;
        ModelMetadata metadata = this.For.Metadata;
        this.Name = this.For.Name;
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder input = this.Generator.GenerateInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) "true", string.Empty, "checkbox", (IDictionary<string, object>) dictionary);
      TagBuilder hiddenForCheckbox = this.Generator.GenerateHiddenForCheckbox(this.ViewContext, this.Name, (IDictionary<string, object>) dictionary);
      output.Content.AppendHtml((IHtmlContent) hiddenForCheckbox);
      output.TagName = "input";
      output.MergeAttributes(input);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Switch", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "Switch";
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

    public bool? Checked { get; set; }

    public bool? Enabled { get; set; }

    public bool? Readonly { get; set; }

    [HtmlAttributeNotBound]
    public SwitchMessagesSettingsTagHelper Messages { get; set; }

    public double? Width { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Checked.HasValue)
        dictionary["checked"] = (object) this.Checked;
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      if (this.Readonly.HasValue)
        dictionary["readonly"] = (object) this.Readonly;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
