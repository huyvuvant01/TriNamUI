// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.NumericTextBoxTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
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
  [HtmlTargetElement("kendo-numerictextbox", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("numerictextbox-editor", ParentTag = "form-item")]
  [RestrictChildren("numerictextbox-label", new string[] {})]
  public class NumericTextBoxTagHelper : TagHelperBase, IKendoFormEditor
  {
    public 
    #nullable disable
    ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public NumericTextBoxTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      NumericTextBoxTagHelper textBoxTagHelper = this;
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
      double? nullable;
      if (this.For != null)
      {
        modelExplorer = this.For.ModelExplorer;
        ModelMetadata metadata = this.For.Metadata;
        this.Name = this.For.Name;
        if (!this.Value.HasValue && this.For.Model != null)
          this.Value = new double?(Convert.ToDouble(this.For.Model));
        this.Format = this.Format ?? this.ExtractEditFormat(this.For.ModelExplorer.Metadata.EditFormatString);
        nullable = this.Min;
        this.Min = nullable ?? this.GetRangeValidationParameter<double>(modelExplorer, "min");
        nullable = this.Max;
        this.Max = nullable ?? this.GetRangeValidationParameter<double>(modelExplorer, "max");
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      nullable = this.Min;
      if (nullable.HasValue)
        dictionary.Add("min", (object) "{0}".FormatWith((object) this.Min));
      nullable = this.Max;
      if (nullable.HasValue)
        dictionary.Add("max", (object) "{0}".FormatWith((object) this.Max));
      nullable = this.Step;
      if (nullable.HasValue)
        dictionary.Add("step", (object) "{0}".FormatWith((object) this.Step));
      TagBuilder numericInput = this.Generator.GenerateNumericInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) this.Value, string.Empty, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.StartTagAndEndTag;
      output.MergeAttributes(numericInput);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "NumericTextBox", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "NumericTextBox";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnSpin { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onSpin = this.OnSpin;
      if ((onSpin != null ? (onSpin.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spin"] = (object) this.CreateHandler(this.OnSpin);
      return dictionary;
    }

    public string Culture { get; set; }

    public int? Decimals { get; set; }

    public string DownArrowText { get; set; }

    public double? Factor { get; set; }

    public string Format { get; set; }

    [HtmlAttributeNotBound]
    public NumericTextBoxLabelSettingsTagHelper Label { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public string Placeholder { get; set; }

    public bool? RestrictDecimals { get; set; }

    public bool? Round { get; set; }

    public bool? SelectOnFocus { get; set; }

    public bool? Spinners { get; set; }

    public double? Step { get; set; }

    public string UpArrowText { get; set; }

    public double? Value { get; set; }

    public bool? Enable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["culture"] = (object) this.Culture;
      if (this.Decimals.HasValue)
        dictionary["decimals"] = (object) this.Decimals;
      string downArrowText = this.DownArrowText;
      if ((downArrowText != null ? (downArrowText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["downArrowText"] = (object) this.DownArrowText;
      double? nullable1 = this.Factor;
      if (nullable1.HasValue)
        dictionary["factor"] = (object) this.Factor;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      if (this.Label != null)
      {
        Dictionary<string, object> source = this.Label.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["label"] = (object) source;
      }
      nullable1 = this.Max;
      if (nullable1.HasValue)
        dictionary["max"] = (object) this.Max;
      nullable1 = this.Min;
      if (nullable1.HasValue)
        dictionary["min"] = (object) this.Min;
      string placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["placeholder"] = (object) this.Placeholder;
      bool? nullable2 = this.RestrictDecimals;
      if (nullable2.HasValue)
        dictionary["restrictDecimals"] = (object) this.RestrictDecimals;
      nullable2 = this.Round;
      if (nullable2.HasValue)
        dictionary["round"] = (object) this.Round;
      nullable2 = this.SelectOnFocus;
      if (nullable2.HasValue)
        dictionary["selectOnFocus"] = (object) this.SelectOnFocus;
      nullable2 = this.Spinners;
      if (nullable2.HasValue)
        dictionary["spinners"] = (object) this.Spinners;
      nullable1 = this.Step;
      if (nullable1.HasValue)
        dictionary["step"] = (object) this.Step;
      string upArrowText = this.UpArrowText;
      if ((upArrowText != null ? (upArrowText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["upArrowText"] = (object) this.UpArrowText;
      nullable2 = this.Enable;
      if (nullable2.HasValue)
        dictionary["enable"] = (object) this.Enable;
      return dictionary;
    }
  }
}
