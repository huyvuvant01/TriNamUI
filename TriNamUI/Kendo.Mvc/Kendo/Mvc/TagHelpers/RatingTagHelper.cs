// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.RatingTagHelper
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
  [HtmlTargetElement("kendo-rating")]
  [HtmlTargetElement("rating-editor", ParentTag = "form-item")]
  [RestrictChildren("label", new string[] {})]
  public class RatingTagHelper : TagHelperBase, IKendoFormEditor
  {
    public RatingTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      RatingTagHelper ratingTagHelper = this;
      context.Items[(object) ratingTagHelper.GetType()] = (object) ratingTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (ratingTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await ratingTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer modelExplorer = (ModelExplorer) null;
      double? nullable;
      if (this.For != null)
      {
        modelExplorer = this.For.ModelExplorer;
        this.Name = this.For.Name;
        if (!this.Value.HasValue && this.For.Model != null)
          this.Value = new double?(Convert.ToDouble(this.For.Model));
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
      TagBuilder numericInput = this.Generator.GenerateNumericInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) this.Value, string.Empty, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.SelfClosing;
      output.MergeAttributes(numericInput);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Rating", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "Rating";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    public double? Min { get; set; }

    public double? Max { get; set; }

    public string Selection { get; set; }

    public string Precision { get; set; }

    public bool? Tooltip { get; set; }

    [HtmlAttributeNotBound]
    public RatingLabelSettingsTagHelper Label { get; set; }

    public double? SelectValueOnFocus { get; set; }

    public string ItemTemplate { get; set; }

    public string ItemTemplateId { get; set; }

    public string SelectedTemplate { get; set; }

    public string SelectedTemplateId { get; set; }

    public string HoveredTemplate { get; set; }

    public string HoveredTemplateId { get; set; }

    public bool? Enabled { get; set; }

    public bool? Readonly { get; set; }

    public double? Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Min.HasValue)
        dictionary["min"] = (object) this.Min;
      if (this.Max.HasValue)
        dictionary["max"] = (object) this.Max;
      string selection = this.Selection;
      if ((selection != null ? (selection.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selection"] = (object) this.Selection;
      string precision = this.Precision;
      if ((precision != null ? (precision.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["precision"] = (object) this.Precision;
      if (this.Tooltip.HasValue)
        dictionary["tooltip"] = (object) this.Tooltip;
      if (this.Label != null)
      {
        Dictionary<string, object> source = this.Label.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Label.Enabled.HasValue || this.Label.Enabled.Value))
          dictionary["label"] = (object) source;
        else if (this.Label.Enabled.HasValue && !this.Label.Enabled.Value)
          dictionary["label"] = (object) this.Label.Enabled;
      }
      if (this.SelectValueOnFocus.HasValue)
        dictionary["selectValueOnFocus"] = (object) this.SelectValueOnFocus;
      if (this.ItemTemplateId.HasValue())
        dictionary["itemTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ItemTemplateId)
        };
      else if (this.ItemTemplate.HasValue())
        dictionary["itemTemplate"] = (object) this.ItemTemplate;
      if (this.SelectedTemplateId.HasValue())
        dictionary["selectedTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.SelectedTemplateId)
        };
      else if (this.SelectedTemplate.HasValue())
        dictionary["selectedTemplate"] = (object) this.SelectedTemplate;
      if (this.HoveredTemplateId.HasValue())
        dictionary["hoveredTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.HoveredTemplateId)
        };
      else if (this.HoveredTemplate.HasValue())
        dictionary["hoveredTemplate"] = (object) this.HoveredTemplate;
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      if (this.Readonly.HasValue)
        dictionary["readonly"] = (object) this.Readonly;
      if (this.Value.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
