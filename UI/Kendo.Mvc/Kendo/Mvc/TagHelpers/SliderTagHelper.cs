// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SliderTagHelper
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
  [HtmlTargetElement("kendo-slider")]
  [HtmlTargetElement("slider-editor", ParentTag = "form-item")]
  [RestrictChildren("slider-tooltip", new string[] {})]
  [OutputElementHint("div")]
  public class SliderTagHelper : TagHelperBase, IKendoFormEditor
  {
    public SliderTagHelper(
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
      SliderTagHelper sliderTagHelper = this;
      context.Items[(object) sliderTagHelper.GetType()] = (object) sliderTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (sliderTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await sliderTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      double? nullable;
      if (this.For != null)
      {
        ModelExplorer modelExplorer = this.For.ModelExplorer;
        ModelMetadata metadata = this.For.Metadata;
        this.Name = this.For.Name;
        if (!this.Value.HasValue && this.For.Model != null)
          this.Value = new double?(Convert.ToDouble(this.For.Model));
        nullable = this.Min;
        this.Min = nullable ?? this.GetRangeValidationParameter<double>(modelExplorer, "min");
        nullable = this.Max;
        this.Max = nullable ?? this.GetRangeValidationParameter<double>(modelExplorer, "max");
      }
      nullable = this.LargeStep;
      if (!nullable.HasValue)
      {
        this.LargeStep = new double?(5.0);
        nullable = this.LargeStep;
        double? smallStep = this.SmallStep;
        if (nullable.GetValueOrDefault() < smallStep.GetValueOrDefault() & nullable.HasValue & smallStep.HasValue)
          this.LargeStep = this.SmallStep;
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("input", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "input";
      output.TagMode = TagMode.SelfClosing;
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Slider", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "Slider";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnSlide { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onSlide = this.OnSlide;
      if ((onSlide != null ? (onSlide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["slide"] = (object) this.CreateHandler(this.OnSlide);
      return dictionary;
    }

    public string DecreaseButtonTitle { get; set; }

    public string DragHandleTitle { get; set; }

    public string IncreaseButtonTitle { get; set; }

    public double? LargeStep { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public bool? ShowButtons { get; set; }

    public double? SmallStep { get; set; }

    [HtmlAttributeNotBound]
    public SliderTooltipSettingsTagHelper Tooltip { get; set; }

    public double? Value { get; set; }

    public SliderOrientation? Orientation { get; set; }

    public SliderTickPlacement? TickPlacement { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      string decreaseButtonTitle = this.DecreaseButtonTitle;
      if ((decreaseButtonTitle != null ? (decreaseButtonTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["decreaseButtonTitle"] = (object) this.DecreaseButtonTitle;
      string dragHandleTitle = this.DragHandleTitle;
      if ((dragHandleTitle != null ? (dragHandleTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dragHandleTitle"] = (object) this.DragHandleTitle;
      string increaseButtonTitle = this.IncreaseButtonTitle;
      if ((increaseButtonTitle != null ? (increaseButtonTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["increaseButtonTitle"] = (object) this.IncreaseButtonTitle;
      double? nullable = this.LargeStep;
      if (nullable.HasValue)
        dictionary1["largeStep"] = (object) this.LargeStep;
      nullable = this.Max;
      if (nullable.HasValue)
        dictionary1["max"] = (object) this.Max;
      nullable = this.Min;
      if (nullable.HasValue)
        dictionary1["min"] = (object) this.Min;
      if (this.ShowButtons.HasValue)
        dictionary1["showButtons"] = (object) this.ShowButtons;
      nullable = this.SmallStep;
      if (nullable.HasValue)
        dictionary1["smallStep"] = (object) this.SmallStep;
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tooltip"] = (object) source;
      }
      nullable = this.Value;
      if (nullable.HasValue)
        dictionary1["value"] = (object) this.Value;
      SliderOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        orientation = this.Orientation;
        ref SliderOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      SliderTickPlacement? tickPlacement = this.TickPlacement;
      if (tickPlacement.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        tickPlacement = this.TickPlacement;
        ref SliderTickPlacement? local = ref tickPlacement;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["tickPlacement"] = (object) str;
      }
      return dictionary1;
    }
  }
}
