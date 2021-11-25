// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NumericTextBox`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class NumericTextBox<T> : WidgetBase, IFormEditor where T : struct
  {
    public NumericTextBox(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder numericInput = this.Generator.GenerateNumericInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, string.Empty, this.HtmlAttributes);
      if (this.Value.HasValue)
        numericInput.MergeAttribute("value", "{0}".FormatWith((object) this.Value));
      numericInput.TagRenderMode = TagRenderMode.SelfClosing;
      numericInput.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) this.SerializeSettings();

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (NumericTextBox<T>), this.Serialize()));

    public string Culture { get; set; }

    public int? Decimals { get; set; }

    public string DownArrowText { get; set; }

    public double? Factor { get; set; }

    public string Format { get; set; }

    public NumericTextBoxLabelSettings<T> Label { get; } = new NumericTextBoxLabelSettings<T>();

    public T? Max { get; set; }

    public T? Min { get; set; }

    public string Placeholder { get; set; }

    public bool? RestrictDecimals { get; set; }

    public bool? Round { get; set; }

    public bool? SelectOnFocus { get; set; }

    public bool? Spinners { get; set; }

    public T? Step { get; set; }

    public string UpArrowText { get; set; }

    public T? Value { get; set; }

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
      if (this.Factor.HasValue)
        dictionary["factor"] = (object) this.Factor;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      Dictionary<string, object> source = this.Label.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["label"] = (object) source;
      T? nullable1 = this.Max;
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
