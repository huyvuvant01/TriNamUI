// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.CheckBoxGroupTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
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
  [HtmlTargetElement("kendo-checkboxgroup")]
  [HtmlTargetElement("checkboxgroup-editor", ParentTag = "form-item")]
  [RestrictChildren("kendo-checkboxgroup-items", new string[] {})]
  public class CheckBoxGroupTagHelper : TagHelperBase, IKendoFormEditor
  {
    public CheckBoxGroupTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeName("bind-to")]
    public IList<IInputGroupItem> BindTo { get; set; }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "CheckBoxGroup", (IDictionary<string, object>) this.Serialize());

    public ModelExpression For { get; set; }

    public IEnumerable<string> Value { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      CheckBoxGroupTagHelper boxGroupTagHelper = this;
      context.Items[(object) boxGroupTagHelper.GetType()] = (object) boxGroupTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (boxGroupTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await boxGroupTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer explorer = (ModelExplorer) null;
      if (this.For != null)
      {
        this.Name = this.For.Name;
        explorer = this.For.ModelExplorer;
        if (this.Value == null && this.For.Model != null)
          this.Value = this.For.Model as IEnumerable<string>;
      }
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      AttributeDictionary attributes = this.Generator.GeneratePseudoBuilder(this.ViewContext, explorer, this.Name).Attributes;
      TagBuilder tag = this.Generator.GenerateTag("ul", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) dictionary);
      tag.MergeAttributes<string, string>((IDictionary<string, string>) attributes);
      output.TagName = "ul";
      output.MergeAttributes(tag);
    }

    private IEnumerable<string> GetValue()
    {
      ModelStateEntry modelStateEntry;
      if (this.ViewContext.ViewData.ModelState.TryGetValue(this.Name, out modelStateEntry) && modelStateEntry.RawValue != null)
        return modelStateEntry.RawValue as IEnumerable<string>;
      return this.Value == null ? this.ViewContext.ViewData.Eval(this.Name) as IEnumerable<string> : this.Value;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.BindTo != null && this.BindTo.Any<IInputGroupItem>())
      {
        IEnumerable<Dictionary<string, object>> source = this.BindTo.Select<IInputGroupItem, CheckBoxGroupItemTagHelper>((Func<IInputGroupItem, CheckBoxGroupItemTagHelper>) (v => new CheckBoxGroupItemTagHelper()
        {
          CssClass = v.CssClass,
          Enabled = v.Enabled,
          Encoded = v.Encoded,
          HtmlAttributes = v.HtmlAttributes,
          Label = v.Label,
          Value = v.Value
        })).Select<CheckBoxGroupItemTagHelper, Dictionary<string, object>>((Func<CheckBoxGroupItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      IEnumerable<string> strings = this.GetValue();
      if (strings != null)
        dictionary["value"] = (object) strings;
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
          formItemTagHelper1.Editor = "CheckBoxGroup";
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
    public CheckBoxGroupItemsTagHelper Items { get; set; }

    public CheckBoxGroupLayout? Layout { get; set; }

    public CheckBoxGroupLabelPosition? LabelPosition { get; set; }

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
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<CheckBoxGroupItemTagHelper, Dictionary<string, object>>((Func<CheckBoxGroupItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["items"] = (object) source;
      }
      if (this.Layout.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        CheckBoxGroupLayout? layout = this.Layout;
        ref CheckBoxGroupLayout? local = ref layout;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["layout"] = (object) str;
      }
      if (this.LabelPosition.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        CheckBoxGroupLabelPosition? labelPosition = this.LabelPosition;
        ref CheckBoxGroupLabelPosition? local = ref labelPosition;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["labelPosition"] = (object) str;
      }
      return dictionary1;
    }
  }
}
