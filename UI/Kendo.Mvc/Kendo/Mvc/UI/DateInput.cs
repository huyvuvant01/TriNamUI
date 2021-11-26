// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DateInput
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DateInput : WidgetBase, IFormEditor
  {
    public DateInput(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateDateInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, this.Format, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) this.SerializeSettings();

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (DateInput), this.Serialize()));

    public string Format { get; set; }

    public DateTime? Max { get; set; }

    public DateTime? Min { get; set; }

    public DateTime? Value { get; set; }

    public DateInputMessagesSettings Messages { get; } = new DateInputMessagesSettings();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      DateTime? nullable = this.Max;
      if (nullable.HasValue)
        dictionary["max"] = (object) this.Max;
      nullable = this.Min;
      if (nullable.HasValue)
        dictionary["min"] = (object) this.Min;
      nullable = this.Value;
      if (nullable.HasValue)
        dictionary["value"] = (object) this.Value;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source;
      return dictionary;
    }
  }
}
