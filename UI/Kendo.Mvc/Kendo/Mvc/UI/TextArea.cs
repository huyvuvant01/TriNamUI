// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TextArea
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
  public class TextArea : WidgetBase, IFormEditor
  {
    public TextArea(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateBoundElement("textarea", this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, string.Empty, string.Empty, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      IDictionary<string, object> options = this.Serialize();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (TextArea), options));
    }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) this.SerializeSettings();

    public double? Cols { get; set; }

    public bool? Enable { get; set; }

    public TextAreaLabelSettings Label { get; } = new TextAreaLabelSettings();

    public double? MaxLength { get; set; }

    public string Placeholder { get; set; }

    public bool? Readonly { get; set; }

    public string Resizable { get; set; }

    public double? Rows { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Cols.HasValue)
        dictionary["cols"] = (object) this.Cols;
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      Dictionary<string, object> source = this.Label.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["label"] = (object) source;
      if (this.MaxLength.HasValue)
        dictionary["maxLength"] = (object) this.MaxLength;
      string placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["placeholder"] = (object) this.Placeholder;
      if (this.Readonly.HasValue)
        dictionary["readonly"] = (object) this.Readonly;
      string resizable = this.Resizable;
      if ((resizable != null ? (resizable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resizable"] = (object) this.Resizable;
      if (this.Rows.HasValue)
        dictionary["rows"] = (object) this.Rows;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
