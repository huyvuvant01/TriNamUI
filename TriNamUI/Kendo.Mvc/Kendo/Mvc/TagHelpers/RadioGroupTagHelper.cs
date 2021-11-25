// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.RadioGroupTagHelper
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
  [HtmlTargetElement("kendo-radiogroup")]
  [HtmlTargetElement("radiogroup-editor", ParentTag = "form-item")]
  [RestrictChildren("kendo-radiogroup-items", new string[] {})]
  public class RadioGroupTagHelper : TagHelperBase, IKendoFormEditor
  {
    public RadioGroupTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeName("bind-to")]
    public IList<IInputGroupItem> BindTo { get; set; }

    public ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      RadioGroupTagHelper radioGroupTagHelper = this;
      context.Items[(object) radioGroupTagHelper.GetType()] = (object) radioGroupTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (radioGroupTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await radioGroupTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer explorer = (ModelExplorer) null;
      if (this.For != null)
      {
        this.Name = this.For.Name;
        explorer = this.For.ModelExplorer;
        if (this.Value == null && this.For.Model != null)
          this.Value = Convert.ToString(this.For.Model);
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      AttributeDictionary attributes = this.Generator.GeneratePseudoBuilder(this.ViewContext, explorer, this.Name).Attributes;
      TagBuilder tag = this.Generator.GenerateTag("ul", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) dictionary);
      tag.MergeAttributes<string, string>((IDictionary<string, string>) attributes);
      output.TagName = "ul";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "RadioGroup", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.BindTo != null && this.BindTo.Any<IInputGroupItem>())
      {
        IEnumerable<Dictionary<string, object>> source = this.BindTo.Select<IInputGroupItem, RadioGroupItemTagHelper>((Func<IInputGroupItem, RadioGroupItemTagHelper>) (v => new RadioGroupItemTagHelper()
        {
          CssClass = v.CssClass,
          Enabled = v.Enabled,
          Encoded = v.Encoded,
          HtmlAttributes = v.HtmlAttributes,
          Label = v.Label,
          Value = v.Value
        })).Select<RadioGroupItemTagHelper, Dictionary<string, object>>((Func<RadioGroupItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
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
          formItemTagHelper1.Editor = "RadioGroup";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnFocus { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onFocus = this.OnFocus;
      if ((onFocus != null ? (onFocus.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["focus"] = (object) this.CreateHandler(this.OnFocus);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    public bool? Enabled { get; set; }

    public string InputName { get; set; }

    [HtmlAttributeNotBound]
    public RadioGroupItemsTagHelper Items { get; set; }

    public string Value { get; set; }

    public RadioGroupLayout? Layout { get; set; }

    public RadioGroupLabelPosition? LabelPosition { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Enabled.HasValue)
        dictionary1["enabled"] = (object) this.Enabled;
      string inputName = this.InputName;
      if ((inputName != null ? (inputName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["inputName"] = (object) this.InputName;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<RadioGroupItemTagHelper, Dictionary<string, object>>((Func<RadioGroupItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["items"] = (object) source;
      }
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.Layout.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        RadioGroupLayout? layout = this.Layout;
        ref RadioGroupLayout? local = ref layout;
        string str2 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["layout"] = (object) str2;
      }
      if (this.LabelPosition.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        RadioGroupLabelPosition? labelPosition = this.LabelPosition;
        ref RadioGroupLabelPosition? local = ref labelPosition;
        string str3 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["labelPosition"] = (object) str3;
      }
      return dictionary1;
    }
  }
}
