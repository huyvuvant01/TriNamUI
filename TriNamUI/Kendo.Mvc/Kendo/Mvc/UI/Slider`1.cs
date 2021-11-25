// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Slider`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Slider<T> : 
    WidgetBase,
    IInputComponent<T>,
    IWidget,
    IHtmlAttributesContainer,
    IFormEditor
    where T : struct, IComparable
  {
    public Slider(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public override void ProcessSettings()
    {
      Func<object, T?> converter = (Func<object, T?>) (val => new T?((T) Convert.ChangeType(val, typeof (T))));
      if (this.GetAttemptedValue<T>() == null)
      {
        T? min = this.GetValue<T>(converter);
        if (!min.HasValue)
          min = this.Min;
        string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0}", (object) min);
      }
      T? largeStep = this.LargeStep;
      if (!largeStep.HasValue)
      {
        this.LargeStep = new T?((T) Convert.ChangeType((object) 5, typeof (T)));
        largeStep = this.LargeStep;
        if (largeStep.Value.CompareTo((object) this.SmallStep) < 0)
          this.LargeStep = this.SmallStep;
      }
      base.ProcessSettings();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder rangeInput = this.Generator.GenerateRangeInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, this.HtmlAttributes);
      T? nullable = this.SmallStep;
      if (nullable.HasValue)
      {
        TagBuilder tagBuilder = rangeInput;
        nullable = this.SmallStep;
        string str = nullable.ToString();
        tagBuilder.MergeAttribute("step", str);
      }
      nullable = this.Min;
      if (nullable.HasValue)
      {
        TagBuilder tagBuilder = rangeInput;
        nullable = this.Min;
        string str = nullable.ToString();
        tagBuilder.MergeAttribute("min", str);
      }
      nullable = this.Max;
      if (nullable.HasValue)
      {
        TagBuilder tagBuilder = rangeInput;
        nullable = this.Max;
        string str = nullable.ToString();
        tagBuilder.MergeAttribute("max", str);
      }
      nullable = this.Value;
      if (!nullable.HasValue)
        rangeInput.Attributes.Remove("value");
      rangeInput.TagRenderMode = TagRenderMode.SelfClosing;
      rangeInput.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) this.SerializeSettings();

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (Slider<T>), this.Serialize()));

    public string DecreaseButtonTitle { get; set; }

    public string DragHandleTitle { get; set; }

    public string IncreaseButtonTitle { get; set; }

    public T? LargeStep { get; set; }

    public T? Max { get; set; }

    public T? Min { get; set; }

    public bool? ShowButtons { get; set; }

    public T? SmallStep { get; set; }

    public SliderTooltipSettings<T> Tooltip { get; } = new SliderTooltipSettings<T>();

    public T? Value { get; set; }

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
      T? nullable = this.LargeStep;
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
      Dictionary<string, object> source = this.Tooltip.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["tooltip"] = (object) source;
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
