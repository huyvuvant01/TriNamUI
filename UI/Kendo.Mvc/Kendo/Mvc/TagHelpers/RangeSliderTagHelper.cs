// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.RangeSliderTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-rangeslider")]
  [RestrictChildren("slider-tooltip", new string[] {})]
  [OutputElementHint("div")]
  public class RangeSliderTagHelper : TagHelperBase
  {
    public RangeSliderTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public ModelExpression For { get; set; }

    public double[] Values { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      RangeSliderTagHelper rangeSliderTagHelper = this;
      context.Items[(object) rangeSliderTagHelper.GetType()] = (object) rangeSliderTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await rangeSliderTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      double? nullable;
      if (this.For != null)
      {
        ModelExplorer modelExplorer = this.For.ModelExplorer;
        ModelMetadata metadata = this.For.Metadata;
        this.Name = this.For.Name;
        if (this.Values == null && this.For.Model != null)
          this.Values = this.For.Model as double[];
        nullable = this.Min;
        this.Min = nullable ?? this.GetRangeValidationParameter<double>(modelExplorer, "min");
        nullable = this.Max;
        this.Max = nullable ?? this.GetRangeValidationParameter<double>(modelExplorer, "max");
      }
      if (this.Values != null && ((IEnumerable<double>) this.Values).Count<double>() >= 1)
        this.SelectionStart = new double?(((IEnumerable<double>) this.Values).First<double>());
      if (this.Values != null && ((IEnumerable<double>) this.Values).Count<double>() > 1)
        this.SelectionEnd = new double?(this.Values[1]);
      nullable = this.SelectionStart;
      if (!nullable.HasValue)
        this.SelectionStart = this.Min;
      nullable = this.SelectionEnd;
      if (!nullable.HasValue)
        this.SelectionEnd = this.Max;
      nullable = this.LargeStep;
      if (!nullable.HasValue)
      {
        this.LargeStep = new double?(5.0);
        nullable = this.LargeStep;
        double? smallStep = this.SmallStep;
        if (nullable.GetValueOrDefault() < smallStep.GetValueOrDefault() & nullable.HasValue & smallStep.HasValue)
          this.LargeStep = this.SmallStep;
      }
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder tag1 = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) dictionary);
      output.TagName = "div";
      output.MergeAttributes(tag1);
      TagBuilder tag2 = this.Generator.GenerateTag("input", this.ViewContext, this.Id, string.Format("{0}[0]", (object) this.Name), (IDictionary<string, object>) dictionary);
      output.Content.AppendHtml((IHtmlContent) tag2);
      TagBuilder tag3 = this.Generator.GenerateTag("input", this.ViewContext, this.Id, string.Format("{0}[1]", (object) this.Name), (IDictionary<string, object>) dictionary);
      output.Content.AppendHtml((IHtmlContent) tag3);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "RangeSlider", (IDictionary<string, object>) this.SerializeSettings());

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

    public double? LargeStep { get; set; }

    public string LeftDragHandleTitle { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public SliderOrientation? Orientation { get; set; }

    public string RightDragHandleTitle { get; set; }

    public double? SelectionEnd { get; set; }

    public double? SelectionStart { get; set; }

    public double? SmallStep { get; set; }

    public SliderTickPlacement? TickPlacement { get; set; }

    [HtmlAttributeNotBound]
    public RangeSliderTooltipSettingsTagHelper Tooltip { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.LargeStep.HasValue)
        dictionary1["largeStep"] = (object) this.LargeStep;
      string leftDragHandleTitle = this.LeftDragHandleTitle;
      if ((leftDragHandleTitle != null ? (leftDragHandleTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["leftDragHandleTitle"] = (object) this.LeftDragHandleTitle;
      if (this.Max.HasValue)
        dictionary1["max"] = (object) this.Max;
      if (this.Min.HasValue)
        dictionary1["min"] = (object) this.Min;
      if (this.Orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        SliderOrientation? orientation = this.Orientation;
        ref SliderOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      string rightDragHandleTitle = this.RightDragHandleTitle;
      if ((rightDragHandleTitle != null ? (rightDragHandleTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["rightDragHandleTitle"] = (object) this.RightDragHandleTitle;
      if (this.SelectionEnd.HasValue)
        dictionary1["selectionEnd"] = (object) this.SelectionEnd;
      if (this.SelectionStart.HasValue)
        dictionary1["selectionStart"] = (object) this.SelectionStart;
      if (this.SmallStep.HasValue)
        dictionary1["smallStep"] = (object) this.SmallStep;
      if (this.TickPlacement.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        SliderTickPlacement? tickPlacement = this.TickPlacement;
        ref SliderTickPlacement? local = ref tickPlacement;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["tickPlacement"] = (object) str;
      }
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tooltip"] = (object) source;
      }
      return dictionary1;
    }
  }
}
