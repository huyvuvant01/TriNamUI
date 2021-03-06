// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RadioButton
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace Kendo.Mvc.UI
{
  public class RadioButton : WidgetBase, IWidget, IHtmlAttributesContainer
  {
    public RadioButton(ViewContext viewContext)
      : base(viewContext)
    {
      this.Enabled = new bool?(true);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.VerifySettings();
      this.GetHtmlBuilder().WriteHtml(writer, this.HtmlEncoder);
    }

    protected virtual RadioButtonHtmlBuilder GetHtmlBuilder() => new RadioButtonHtmlBuilder(this, this.Generator);

    public bool? Checked { get; set; }

    public bool? Enabled { get; set; }

    public string Label { get; set; }

    public object Value { get; set; }
  }
}
