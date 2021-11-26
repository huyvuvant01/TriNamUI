// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RangeSlider`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class RangeSlider<T> : WidgetBase, IWidget, IHtmlAttributesContainer
    where T : struct, IComparable
  {
    public RangeSlider(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public override void ProcessSettings()
    {
      if (!this.SelectionStart.HasValue)
        this.SelectionStart = this.Min;
      if (!this.SelectionEnd.HasValue)
        this.SelectionEnd = this.Max;
      if (!this.LargeStep.HasValue)
      {
        this.LargeStep = new T?((T) Convert.ChangeType((object) 5, typeof (T)));
        if (this.LargeStep.Value.CompareTo((object) this.SmallStep) < 0)
          this.LargeStep = this.SmallStep;
      }
      base.ProcessSettings();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      ModelMetadata metadata = ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider).Metadata;
      TagBuilder tag1 = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      TagBuilder tag2 = this.Generator.GenerateTag("input", this.ViewContext, this.Id, string.Format("{0}[0]", (object) this.Name), this.HtmlAttributes);
      tag2.Attributes.Remove("id");
      if (this.SelectionStart.HasValue)
        tag2.MergeAttribute("value", this.GetValue<T?>("{0}[0]".FormatWith((object) this.Name), this.SelectionStart));
      TagBuilder tag3 = this.Generator.GenerateTag("input", this.ViewContext, this.Id, string.Format("{0}[1]", (object) this.Name), this.HtmlAttributes);
      tag3.Attributes.Remove("id");
      T? nullable = this.SelectionEnd;
      if (nullable.HasValue)
        tag3.MergeAttribute("value", this.GetValue<T?>("{0}[1]".FormatWith((object) this.Name), this.SelectionEnd));
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      dictionary.Add("type", (object) "range");
      nullable = this.SmallStep;
      if (nullable.HasValue)
        dictionary.Add("step", (object) this.SmallStep);
      nullable = this.Min;
      if (nullable.HasValue)
        dictionary.Add("min", (object) this.Min);
      nullable = this.Max;
      if (nullable.HasValue)
        dictionary.Add("max", (object) this.Max);
      tag2.MergeAttributes<string, object>((IDictionary<string, object>) dictionary);
      tag3.MergeAttributes<string, object>((IDictionary<string, object>) dictionary);
      tag1.TagRenderMode = TagRenderMode.StartTag;
      tag1.WriteTo(writer, this.HtmlEncoder);
      tag2.TagRenderMode = TagRenderMode.SelfClosing;
      tag2.WriteTo(writer, this.HtmlEncoder);
      tag3.TagRenderMode = TagRenderMode.SelfClosing;
      tag3.WriteTo(writer, this.HtmlEncoder);
      tag1.TagRenderMode = TagRenderMode.EndTag;
      tag1.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (RangeSlider<T>), (IDictionary<string, object>) dictionary));
    }

    public T? LargeStep { get; set; }

    public string LeftDragHandleTitle { get; set; }

    public T? Max { get; set; }

    public T? Min { get; set; }

    public SliderOrientation? Orientation { get; set; }

    public string RightDragHandleTitle { get; set; }

    public T? SelectionEnd { get; set; }

    public T? SelectionStart { get; set; }

    public T? SmallStep { get; set; }

    public SliderTickPlacement? TickPlacement { get; set; }

    public RangeSliderTooltipSettings<T> Tooltip { get; } = new RangeSliderTooltipSettings<T>();

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
      Dictionary<string, object> source = this.Tooltip.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["tooltip"] = (object) source;
      return dictionary1;
    }
  }
}
